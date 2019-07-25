namespace Photoparallel.Web.Components
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Rents;

    public class OpenRentComponent : ViewComponent
    {
        private readonly IRentsService rentsService;
        private readonly IMapper mapper;

        public OpenRentComponent(IRentsService rentsService, IMapper mapper)
        {
            this.rentsService = rentsService;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rentViewModel = new OpenRentViewModel();

            var openRent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);
            rentViewModel.Id = openRent.Id;

            foreach (var product in openRent.Products)
            {
                var rentProductViewModel = this.mapper.Map<OpenRentsProductsViewModel>(product.Product);

                rentProductViewModel.RentQuantity = product.Quantity;

                rentViewModel.Products.Add(rentProductViewModel);
            }

            rentViewModel.Guarantee = rentViewModel.Products.Sum(x => Math.Round(x.Price * GlobalConstants.GuaranteePercent));

            return this.View(rentViewModel);
        }
    }
}
