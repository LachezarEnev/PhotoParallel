namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;
    using Photoparallel.Web.ViewModels.Orders;
    using X.PagedList;

    public class OrdersController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 15;

        private readonly IOrdersService ordersService;
        private readonly IProductsService productsService;
        private readonly IMapper mapper;

        public OrdersController(IOrdersService ordersService, IProductsService productsService, IMapper mapper)
        {
            this.ordersService = ordersService;
            this.productsService = productsService;
            this.mapper = mapper;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var orderViewModel = new OpenOrderViewModel();

            var openOrder = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            orderViewModel.Id = openOrder.Id;
            orderViewModel.TotalPrice = openOrder.TotalPrice;

            foreach (var product in openOrder.Products)
            {
                var orderProductViewModel = this.mapper.Map<OpenOrdersProductsViewModel>(product.Product);

                orderProductViewModel.OrderQuantity = product.Quantity;
                orderProductViewModel.TotalPrice = product.TotalPrice;

                orderViewModel.Products.Add(orderProductViewModel);
            }

            return this.View(orderViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Add(int id)
        {
            var openOrder = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            await this.ordersService.AddProductAsync(id, openOrder);

            return this.RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            await this.ordersService.DeleteProductAsync(id, order);

            return this.RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id, int quantity)
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            await this.ordersService.EditProductQuantityAsync(id, quantity, order);

            return this.RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> Create()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            if (order == null || order.TotalPrice == 0)
            {
                return this.RedirectToAction("Index");
            }

            var createOrderInputModel = new CreateOrderInputModel
            {
                FirstName = order.Customer.FirstName,
                LastName = order.Customer.LastName,
                PhoneNumber = order.Customer.PhoneNumber,
                TotalPrice = order.TotalPrice,
            };

            return this.View(createOrderInputModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderInputModel model)
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            model.TotalPrice = order.TotalPrice;

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            string shippingAddress = model.City + ", " + model.PostalCode + Environment.NewLine + model.Address;

            await this.ordersService.SetOrderDetailsAsync(order, shippingAddress, model.FirstName, model.LastName, model.PhoneNumber, model.PaymentType);

            return this.RedirectToAction("Confirm");
        }

        [Authorize]
        public async Task<IActionResult> Confirm()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            if (order == null || order.TotalPrice == 0)
            {
                return this.RedirectToAction("Index");
            }

            var orderViewModel = this.mapper.Map<ConfirmOrderViewModel>(order);

            return this.View(orderViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Finish()
        {
            var order = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            if (order == null || order.TotalPrice == 0)
            {
                return this.RedirectToAction("Index");
            }

            await this.ordersService.FinishOrderAsync(order);

            return this.View(order.Id);
        }

        [Authorize]
        public async Task<IActionResult> My(int? pageNumber, int? pageSize)
        {
            var orders = await this.ordersService.GetAllOrdersByUserAsync(this.User.Identity.Name);

            var allOrders = this.mapper.Map<IList<MyOrdersViewModel>>(orders);

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageOrdersViewModel = allOrders.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageOrdersViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);

            if (order == null || order.Customer.UserName != this.User.Identity.Name)
            {
                return this.View("OrderNotFound");
            }

            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(id);
            var orderProductsViewModel = this.mapper.Map<IList<OrderProductsViewModel>>(orderProducts);

            var orderViewModel = this.mapper.Map<OrderDetailsViewModel>(order);
            orderViewModel.OrderProductsViewModel = orderProductsViewModel;

            if (order.OrderStatus == OrderStatus.Pending || order.OrderStatus == OrderStatus.Denied)
            {
                orderViewModel.EstimatedDeliveryDate = "N/A";
                orderViewModel.Invoice = "N/A";
            }
            else
            {
                orderViewModel.EstimatedDeliveryDate = order.EstimatedDeliveryDate?.ToString(@"dd/MM/yyyy");
            }

            return this.View(orderViewModel);
        }
    }
}
