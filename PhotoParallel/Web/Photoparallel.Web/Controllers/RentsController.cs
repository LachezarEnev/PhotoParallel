﻿namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Rents;
    using Photoparallel.Web.ViewModels.Home;
    using Photoparallel.Web.ViewModels.Rents;
    using X.PagedList;

    public class RentsController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 8;
        private const int DefaultMyPageNumber = 1;
        private const int DefaultMyPageSize = 15;

        private readonly IProductsService productsService;
        private readonly IMapper mapper;
        private readonly IRentsService rentsService;

        public RentsController(IProductsService productsService, IMapper mapper, IRentsService rentsService)
        {
            this.productsService = productsService;
            this.mapper = mapper;
            this.rentsService = rentsService;
        }

        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var products = await this.productsService.GetRentProductsAsync();
            products = this.productsService.OrderBy(products, model.SortBy).ToList();

            var productsViewModel = this.mapper.Map<IList<IndexProductViewModel>>(products);
            var allProductsViewModel = this.mapper.Map<IList<AllProductsVieModel>>(products);

            int pageNumber = model.PageNumber ?? DefaultPageNumber;
            int pageSize = model.PageSize ?? DefaultPageSize;
            var pageProductsViewMode = productsViewModel.ToPagedList(pageNumber, pageSize);

            model.ProductsViewModel = pageProductsViewMode;
            model.Products = allProductsViewModel;

            return this.View(model);
        }

        [Authorize]
        public async Task<IActionResult> Open()
        {
            var rentViewModel = new OpenRentViewModel();

            var openOrder = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);
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

        [Authorize]
        public async Task<IActionResult> Add(int id)
        {
            var openRent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            await this.rentsService.AddProductAsync(id, openRent);

            return this.RedirectToAction("Open");
        }

        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var rent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            await this.rentsService.DeleteProductAsync(id, rent);

            return this.RedirectToAction("Open");
        }

        [Authorize]
        public async Task<IActionResult> Rent()
        {
            var rent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            if (rent == null || rent.Products.Count() == 0)
            {
                return this.RedirectToAction("Open");
            }

            var rentProductInputModel = new RentProductInputModel()
            {
                FirstName = rent.Customer.FirstName,
                LastName = rent.Customer.LastName,
                PhoneNumber = rent.Customer.PhoneNumber,
            };

            return this.View(rentProductInputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Rent(RentProductInputModel model)
        {
            var rent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            rent.ShippingAddress = model.City + ", " + model.PostalCode + Environment.NewLine + model.Address;
            rent.Recipient = model.FirstName + " " + model.LastName;
            rent.RentDate = model.RentDate;
            rent.ReturnDate = model.ReturnDate.AddDays(1);
            rent.RecipientPhoneNumber = model.PhoneNumber;
            rent.Comment = model.Comment;
            rent.Guarantee = rent.Products.Sum(x => Math.Round(x.Product.Price * GlobalConstants.GuaranteePercent));

            await this.rentsService.SetRentDetailsAsync(rent);

            return this.RedirectToAction("Confirm");
        }

        [Authorize]
        public async Task<IActionResult> Confirm()
        {
            var rent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            if (rent == null || rent.Products.Count() == 0)
            {
                return this.RedirectToAction("Index");
            }

            var days = rent.ReturnDate - rent.RentDate;

            rent.TotalPrice = rent.Products.Sum(x => x.Product.PricePerDay * (int)days.TotalDays);

            var rentViewModel = this.mapper.Map<ConfirmRentViewModel>(rent);

            return this.View(rentViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Finish()
        {
            var rent = await this.rentsService.CreateOpenRentByUserIdAsync(this.User.Identity.Name);

            if (rent == null || rent.Products.Count() == 0)
            {
                return this.RedirectToAction("Index");
            }

            await this.rentsService.FinishRentAsync(rent);

            return this.View();
        }

        [Authorize]
        public async Task<IActionResult> My(int? pageNumber, int? pageSize)
        {
            var rents = await this.rentsService.GetAllRentsByUserAsync(this.User.Identity.Name);

            var rentsViewModel = this.mapper.Map<IList<MyRentsViewModel>>(rents);

            pageNumber = pageNumber ?? DefaultMyPageNumber;
            pageSize = pageSize ?? DefaultMyPageSize;
            var pageRentsViewModel = rentsViewModel.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageRentsViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var rent = await this.rentsService.GetRentByIdAsync(id);

            if (rent == null || rent.Customer.UserName != this.User.Identity.Name)
            {
                return this.View("OrderNotFound");
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
    }
}
