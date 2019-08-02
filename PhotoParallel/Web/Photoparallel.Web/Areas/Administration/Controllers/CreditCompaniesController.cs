namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.CreditCompanies;

    public class CreditCompaniesController : AdministrationController
    {
        private readonly ICreditCompaniesService creditCompaniesService;
        private readonly IMapper mapper;

        public CreditCompaniesController(ICreditCompaniesService creditCompaniesService, IMapper mapper)
        {
            this.creditCompaniesService = creditCompaniesService;
            this.mapper = mapper;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCompanyInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var company = this.mapper.Map<CreditCompany>(model);

            await this.creditCompaniesService.AddCompanyAsync(company);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> All()
        {
            var companies = await this.creditCompaniesService.GetAllCompaniesAsync();

            var allCompaniesViewModel = this.mapper.Map<IList<AllCreditCompaniesViewModel>>(companies);

            return this.View(allCompaniesViewModel);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var company = await this.creditCompaniesService.GetCompanyByIdAsync(id);

            if (company == null)
            {
                return this.View("CreditCompanyNotFound");
            }

            var model = this.mapper.Map<EditCompanyInputModel>(company);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCompanyInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var comapany = this.mapper.Map<CreditCompany>(model);

            await this.creditCompaniesService.EditCompanyAsync(comapany);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Hide(string id)
        {
            var company = await this.creditCompaniesService.GetCompanyByIdAsync(id);

            if (company == null)
            {
                return this.View("CreditCompanyNotFound");
            }

            await this.creditCompaniesService.HideCompanyAsync(company);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Show(string id)
        {
            var company = await this.creditCompaniesService.GetCompanyByIdAsync(id);

            if (company == null)
            {
                return this.View("CreditCompanyNotFound");
            }

            await this.creditCompaniesService.ShowCompanyAsync(company);

            return this.RedirectToAction("All");
        }
    }
}
