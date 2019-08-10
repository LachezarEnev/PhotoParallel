namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Credits;
    using X.PagedList;

    public class CreditsController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 15;

        private readonly ICreditsService creditsService;
        private readonly IOrdersService ordersService;
        private readonly ICreditCompaniesService creditCompaniesService;
        private readonly AutoMapper.IMapper mapper;

        public CreditsController(ICreditsService creditsService, IOrdersService ordersService, ICreditCompaniesService creditCompaniesService, AutoMapper.IMapper mapper)
        {
            this.creditsService = creditsService;
            this.ordersService = ordersService;
            this.creditCompaniesService = creditCompaniesService;
            this.mapper = mapper;
        }

        [Authorize]
        public async Task<IActionResult> AddProduct(int id)
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            if (order == null)
            {
                return this.RedirectToAction("Index", "Orders");
            }

            await this.ordersService.AddProductAsync(id, order);

            return this.RedirectToAction("Create");
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            var creditCompanis = await this.creditCompaniesService.GetVisibleCompaniesAsync();

            if (order == null || order.TotalPrice < GlobalConstants.MinimumCreditValue)
            {
                return this.RedirectToAction("Index", "Orders");
            }

            if (creditCompanis.Count() == 0)
            {
                return this.View("NoCreditCompanies");
            }

            var creditViewModel = new CreateCreditInputModel()
            {
                FirstName = order.Customer.FirstName,
                LastName = order.Customer.LastName,
                PhoneNumber = order.Customer.PhoneNumber,
                Order = order,
                CreditCompanies = creditCompanis,
            };

            return this.View(creditViewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreateCreditInputModel model)
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            var creditCompanis = await this.creditCompaniesService.GetVisibleCompaniesAsync();
            var creditContract = await this.creditsService.GetOpenCreditsByUserIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            model.Order = order;
            model.CreditCompanies = creditCompanis;

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string address = model.City + ", " + model.PostalCode + Environment.NewLine + model.Address;
            string recipient = model.FirstName + " " + model.LastName;

            await this.ordersService.SetOrderDetailsAsync(order, address, model.FirstName, model.LastName, model.PhoneNumber, PaymentType.Credit);

            var creditCompany = creditCompanis.FirstOrDefault(x => x.Name == model.Company);

            await this.creditsService.SetCreditDetailsAsync(creditContract, order, address, creditCompany, model.Salary, model.Months, model.Ucn, model.IdNumber);

            return this.RedirectToAction("Confirm");
        }

        [Authorize]
        public async Task<IActionResult> Confirm()
        {
            var credit = await this.creditsService.GetOpenCreditsByUserIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            credit.Order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            credit.CreditCompany = await this.creditCompaniesService.GetCompanyByIdAsync(credit.CreditCompanyId);

            if (credit == null || credit.TotalAmount == 0)
            {
                return this.RedirectToAction("Index", "Orders");
            }

            var creditViewModel = this.mapper.Map<ConfirmCreditViewModel>(credit);

            return this.View(creditViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Finish()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            var credit = await this.creditsService.GetOpenCreditsByUserIdAsync(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            if (order == null || order.TotalPrice == 0)
            {
                return this.RedirectToAction("Index", "Orders");
            }

            await this.ordersService.FinishOrderAsync(order);

            await this.creditsService.FinishCreditAsync(credit);

            return this.View();
        }

        [Authorize]
        public async Task<IActionResult> My(int? pageNumber, int? pageSize)
        {
            var credits = await this.creditsService.GetAllCreditsByUserAsync(this.User.Identity.Name);

            var allCredits = this.mapper.Map<IList<MyCreditssViewModel>>(credits);

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageCreditsViewModel = allCredits.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageCreditsViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var credit = await this.creditsService.GetCreditByIdAsync(id);

            if (credit == null || credit.Customer.UserName != this.User.Identity.Name)
            {
                return this.View("CreditNotFound");
            }

            var creditViewModel = this.mapper.Map<CreditDetailsViewModel>(credit);

            return this.View(creditViewModel);
        }
    }
}
