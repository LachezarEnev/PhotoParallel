namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Rents;

    public class RentsController : AdministrationController
    {
        private readonly IRentsService rentsService;
        private readonly IMapper mapper;

        public RentsController(IRentsService rentsService, IMapper mapper)
        {
            this.rentsService = rentsService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Pending()
        {
            var rents = await this.rentsService.GetPendingRentsAsync();

            var allPendingRents = this.mapper.Map<IList<AllRentsViewModel>>(rents);

            return this.View(allPendingRents);
        }

        public async Task<IActionResult> Rented()
        {
            var rents = await this.rentsService.GetRentedRentsAsync();

            var allRentedRents = this.mapper.Map<IList<AllRentsViewModel>>(rents);

            return this.View(allRentedRents);
        }

        public async Task<IActionResult> Returned()
        {
            var rents = await this.rentsService.GetReturnedRentsAsync();

            var allReturnedRents = this.mapper.Map<IList<AllRentsViewModel>>(rents);

            return this.View(allReturnedRents);
        }

        public async Task<IActionResult> Denied()
        {
            var rents = await this.rentsService.GetDeniedRentsAsync();

            var allDeniedRents = this.mapper.Map<IList<AllRentsViewModel>>(rents);

            return this.View(allDeniedRents);
        }

        public async Task<IActionResult> Details(int id)
        {
            var rent = await this.rentsService.GetRentByIdAsync(id);

            if (rent == null)
            {
                return this.RedirectToAction("Pending");
            }

            var rentProducts = await this.rentsService.RentProductsByRentIdAsync(id);
            var rentProductsViewModel = this.mapper.Map<IList<RentProductsViewModel>>(rentProducts);

            var rentViewModel = this.mapper.Map<RentDetailsViewModel>(rent);
            rentViewModel.RentProductsViewModel = rentProductsViewModel;
            rentViewModel.PaymentStatus = "Paid";
            rentViewModel.Days = (int)(rent.ReturnDate - rent.RentDate).TotalDays;

            if (rent.RentStatus == RentStatus.Pending || rent.RentStatus == RentStatus.Denied || rent.RentStatus == RentStatus.Rented)
            {
                rentViewModel.Invoice = "N/A";
            }

            return this.View(rentViewModel);
        }

        public async Task<IActionResult> Ship(int id)
        {
            await this.rentsService.ShipAsync(id);

            return this.RedirectToAction("Pending");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var rent = await this.rentsService.GetRentByIdAsync(id);

            if (rent == null)
            {
                return this.RedirectToAction("Pending");
            }

            var rentViewModel = this.mapper.Map<DeleteRentViewModel>(rent);

            return this.View(rentViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.rentsService.DeleteRentAsync(id);

            return this.RedirectToAction("Denied");
        }

        public async Task<IActionResult> Return(int id)
        {
            var rent = await this.rentsService.GetRentByIdAsync(id);

            if (rent == null)
            {
                return this.RedirectToAction("Rented");
            }

            var returnInputModel = this.mapper.Map<RentReturnInputModel>(rent);

            return this.View(returnInputModel);
        }

        [HttpPost]
        public async Task<IActionResult> Return(RentReturnInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.rentsService.ReturnAsync(model.Id, model.Penalty, model.ReturnedOnTime);

            return this.RedirectToAction("Rented");
        }
    }
}
