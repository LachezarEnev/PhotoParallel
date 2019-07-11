namespace Photoparallel.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;
    using Photoparallel.Web.ViewModels.Orders;

    public class OrdersController : BaseController
    {
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

            foreach (var product in openOrder.Products)
            {
                var orderProduct = await this.ordersService.GetOrderProductAsync(product.ProductId, openOrder);
                var orderProductViewModel = this.mapper.Map<OpenOrdersProductsViewModel>(product.Product);

                orderProductViewModel.OrderQuantity = orderProduct.Quantity;
                orderProductViewModel.TotalPrice = orderProductViewModel.OrderQuantity * orderProductViewModel.Price;

                orderViewModel.Products.Add(orderProductViewModel);
            }

            return this.View(orderViewModel);
        }

        public async Task<IActionResult> Add(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Login");
            }

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
        public async Task<IActionResult> Finish(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);
            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(order.Id);

            bool isOutofStock = false;

            foreach (var product in orderProducts)
            {
                if (product.Product.Quantity < product.Quantity)
                {
                    isOutofStock = true;
                    break;
                }
            }

            if (isOutofStock)
            {
                order.EstimatedDeliveryDate = DateTime.Now.AddDays(10);
            }
            else
            {
                order.EstimatedDeliveryDate = DateTime.Now.AddDays(3);
            }

            return this.RedirectToAction("Index");
        }
    }
}
