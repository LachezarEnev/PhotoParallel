namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Home;
    using Photoparallel.Web.ViewModels.Rents;
    using X.PagedList;

    public class RentsController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 8;

        private readonly IProductsService productsService;
        private readonly IMapper mapper;
        private readonly IUsersService usersService;
        private readonly IRentsService rentsService;

        public RentsController(IProductsService productsService, IMapper mapper, IUsersService usersService, IRentsService rentsService)
        {
            this.productsService = productsService;
            this.mapper = mapper;
            this.usersService = usersService;
            this.rentsService = rentsService;
        }

        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var products = await this.productsService.GetRentProductsAsync();
            products = this.productsService.OrderBy(products, model.SortBy).ToList();

            var productsViewModel = this.mapper.Map<IList<IndexProductViewModel>>(products);

            int pageNumber = model.PageNumber ?? DefaultPageNumber;
            int pageSize = model.PageSize ?? DefaultPageSize;
            var pageProductsViewMode = productsViewModel.ToPagedList(pageNumber, pageSize);

            model.ProductsViewModel = pageProductsViewMode;

            return this.View(model);
        }

        [Authorize]
        public async Task<IActionResult> Open()
        {
            var rentViewModel = new OpenRentViewModel();

            var openOrder = await this.rentsService.GetOpenRentByUserIdAsync(this.User.Identity.Name);
            rentViewModel.Id = openOrder.Id;

            foreach (var product in openOrder.Products)
            {
                var rentProductViewModel = this.mapper.Map<OpenRentsProductsViewModel>(product.Product);

                rentProductViewModel.RentQuantity = product.Quantity;

                rentViewModel.Products.Add(rentProductViewModel);
            }

            rentViewModel.Guarantee = rentViewModel.Products.Sum(x => Math.Round(x.Price * GlobalConstants.GuaranteePercent));

            return this.View(rentViewModel);
        }

        public async Task<IActionResult> Add(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Login");
            }

            var openRent = await this.rentsService.GetOpenRentByUserIdAsync(this.User.Identity.Name);

            await this.rentsService.AddProductAsync(id, openRent);

            return this.RedirectToAction("Open");
        }

        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var rent = await this.rentsService.GetOpenRentByUserIdAsync(this.User.Identity.Name);

            await this.rentsService.DeleteProductAsync(id, rent);

            return this.RedirectToAction("Open");
        }

        [Authorize]
        public async Task<IActionResult> Rent()
        {
            var rent = await this.rentsService.GetOpenRentByUserIdAsync(this.User.Identity.Name);

            if (rent == null || rent.Products.Count() == 0)
            {
                return this.RedirectToAction("Open");
            }

            var rentProductInputModel = new RentProductInputModel()
            {
                FirstName = rent.Customer.FirstName,
                LastName = rent.Customer.LastName,
                RecipientPhoneNumber = rent.Customer.PhoneNumber,
            };

            return this.View(rentProductInputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Rent(RentProductInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string shippingAddress = model.City + ", " + model.PostalCode + Environment.NewLine + model.Address;
            string recipient = model.FirstName + " " + model.LastName;

            var rent = this.mapper.Map<Rent>(model);
            rent.ShippingAddress = shippingAddress;
            rent.Recipient = recipient;

            await this.rentsService.CreatRentAsync(rent);

            return this.View();
        }
    }
}
