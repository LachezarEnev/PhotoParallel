namespace Photoparallel.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Common;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class CreditsService : ICreditsService
    {
        private readonly PhotoparallelDbContext context;
        private readonly IOrdersService ordersService;

        public CreditsService(PhotoparallelDbContext context, IOrdersService ordersService)
        {
            this.context = context;
            this.ordersService = ordersService;
        }

        public async Task ApproveAsync(int id)
        {
            var credit = await this.context.CreditContracts
                .Include(x => x.Order)
                .Where(x => x.Id == id && x.CreditStatus == CreditStatus.Pending)
                .SingleOrDefaultAsync();

            if (credit == null)
            {
                return;
            }

            credit.CreditStatus = CreditStatus.Approved;
            this.context.Update(credit);
            await this.context.SaveChangesAsync();

            await this.ordersService.ApproveAsync(credit.Order.Id);
        }

        public async Task DeleteCreditAsync(int id)
        {
            var credit = await this.context.CreditContracts
                .Include(x => x.Order)
                .Where(x => x.Id == id && x.CreditStatus == CreditStatus.Pending)
                .SingleOrDefaultAsync();

            if (credit == null)
            {
                return;
            }

            credit.CreditStatus = CreditStatus.Denied;
            this.context.Update(credit);
            await this.context.SaveChangesAsync();

            await this.ordersService.DeleteOrderAsync(credit.Order.Id);
        }

        public async Task FinishCreditAsync(CreditContract credit)
        {
            credit.IssuedOn = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);
            credit.ActiveUntil = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddMonths(credit.Months);
            credit.CreditStatus = CreditStatus.Pending;

            this.context.Update(credit);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CreditContract>> GetAllCreditsByUserAsync(string username)
        {
            var credits = await this.context.CreditContracts
                .Where(x => x.CreditStatus != CreditStatus.Open && x.Customer.UserName == username)
                .OrderByDescending(x => x.Id)
                .ToArrayAsync();

            return credits;
        }

        public async Task<IEnumerable<CreditContract>> GetApprovedCreditsAsync()
        {
            var approvedCredits = await this.context.CreditContracts
               .Where(x => x.CreditStatus == CreditStatus.Approved)
               .OrderByDescending(x => x.IssuedOn)
               .ToArrayAsync();

            return approvedCredits;
        }

        public async Task<CreditContract> GetCreditByIdAsync(int id)
        {
            var credit = await this.context.CreditContracts
                .Include(x => x.Customer)
                .Include(x => x.CreditCompany)
                .Include(x => x.Order)
                .Where(x => x.CreditStatus != CreditStatus.Open)
                .FirstOrDefaultAsync(x => x.Id == id);

            return credit;
        }

        public async Task<IEnumerable<CreditContract>> GetDeniedCreditsAsync()
        {
            var deniedCredits = await this.context.CreditContracts
               .Where(x => x.CreditStatus == CreditStatus.Denied)
               .OrderByDescending(x => x.IssuedOn)
               .ToArrayAsync();

            return deniedCredits;
        }

        public async Task<CreditContract> GetOpenCreditsByUserIdAsync(string customerId)
        {
            var openCredit = await this.context.CreditContracts
                .SingleOrDefaultAsync(x => x.CustomerId == customerId && x.CreditStatus == CreditStatus.Open);

            if (openCredit == null)
            {
                openCredit = new CreditContract()
                {
                    CustomerId = customerId,
                };

                this.context.Add(openCredit);
                await this.context.SaveChangesAsync();
            }

            return openCredit;
        }

        public async Task<IEnumerable<CreditContract>> GetPendingCreditsAsync()
        {
            var pendingCredits = await this.context.CreditContracts
                .Where(x => x.CreditStatus == CreditStatus.Pending)
                .OrderBy(x => x.IssuedOn)
                .ToArrayAsync();

            return pendingCredits;
        }

        public async Task SetCreditDetailsAsync(CreditContract creditContract, Order order, string address, CreditCompany creditCompany, decimal salary, int months, string ucn, string idNumber)
        {
            creditContract.CreditCompany = creditCompany;
            creditContract.Address = address;
            creditContract.Months = months;
            creditContract.PricePerMonth = Math.Round(order.TotalPrice / months, 2) + Math.Round((order.TotalPrice * (creditCompany.Interest / GlobalConstants.HundredPercent)) / GlobalConstants.MonthsInYear, 2);
            creditContract.TotalAmount = months * creditContract.PricePerMonth;
            creditContract.ActiveUntil = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddMonths(months);
            creditContract.Customer = order.Customer;
            creditContract.Order = order;
            creditContract.Salary = salary;
            creditContract.Ucn = ucn;
            creditContract.IdNumber = idNumber;

            this.context.Update(creditContract);
            await this.context.SaveChangesAsync();
        }
    }
}
