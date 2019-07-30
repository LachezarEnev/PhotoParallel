namespace Photoparallel.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Common;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class CreditsService : ICreditsService
    {
        private readonly PhotoparallelDbContext context;
        private readonly IMapper mapper;

        public CreditsService(PhotoparallelDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
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

        public async Task SetCreditDetailsAsync(CreditContract creditContract, Order order, string address, CreditCompany creditCompany, decimal salary, int months, string ucn, string idNumber)
        {
            creditContract.CreditCompany = creditCompany;
            creditContract.Address = address;
            creditContract.Months = months;
            creditContract.PricePerMonth = Math.Round(order.TotalPrice / months, 2) + Math.Round((order.TotalPrice * (creditCompany.Interest / 100)) / 12, 2);
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
