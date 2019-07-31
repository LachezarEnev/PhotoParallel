namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Credits;
    using Photoparallel.Web.ViewModels.Credits;

    public class CreditsController : AdministrationController
    {
        private readonly ICreditsService creditsService;
        private readonly IMapper mapper;

        public CreditsController(ICreditsService creditsService, IMapper mapper)
        {
            this.creditsService = creditsService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Pending()
        {
            var credits = await this.creditsService.GetPendingCreditsAsync();

            var allPendingOrders = this.mapper.Map<IList<AllCreditsViewModel>>(credits);

            return this.View(allPendingOrders);
        }

        public async Task<IActionResult> Details(int id)
        {
            var credit = await this.creditsService.GetCreditByIdAsync(id);

            if (credit == null)
            {
                return this.RedirectToAction("Pending");
            }

            var creditViewModel = this.mapper.Map<DetailsCreditViewModel>(credit);

            return this.View(creditViewModel);
        }

        public async Task<IActionResult> CreditDetails(int id)
        {
            var credit = await this.creditsService.GetCreditByIdAsync(id);

            if (credit == null)
            {
                return this.RedirectToAction("Pending");
            }

            var creditViewModel = this.mapper.Map<CreditDetailsViewModel>(credit);

            return this.View(creditViewModel);
        }

        public async Task<IActionResult> Approve(int id)
        {
            await this.creditsService.ApproveAsync(id);

            return this.RedirectToAction("Pending");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var credit = await this.creditsService.GetCreditByIdAsync(id);

            if (credit == null)
            {
                return this.RedirectToAction("Pending");
            }

            var creditViewModel = this.mapper.Map<DeleteCreditViewModel>(credit);

            return this.View(creditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.creditsService.DeleteCreditAsync(id);

            return this.RedirectToAction("Denied");
        }

        public async Task<IActionResult> Approved()
        {
            var credits = await this.creditsService.GetApprovedCreditsAsync();

            var allApprovedCredits = this.mapper.Map<IList<AllCreditsViewModel>>(credits);

            return this.View(allApprovedCredits);
        }

        public async Task<IActionResult> Denied()
        {
            var credits = await this.creditsService.GetDeniedCreditsAsync();

            var allDeniedCredits = this.mapper.Map<IList<AllCreditsViewModel>>(credits);

            return this.View(allDeniedCredits);
        }
    }
}
