namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;

    public class OrdersController : AdministrationController
    {
        private const string ERROR_MESSAGE_INVALID_ORDER_NUMBER = "Invalid order number. Please try again!";

        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;

        public OrdersController(IOrdersService ordersService, IMapper mapper)
        {
            this.ordersService = ordersService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> All()
        {
            var orders = await this.ordersService.GetAllOrdersAsync();

            var allOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allOrders);
        }

        public async Task<IActionResult> Pending()
        {
            var orders = await this.ordersService.GetPendingOrdersAsync();

            var allPendingOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allPendingOrders);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);

            if (order == null)
            {
                this.TempData["error"] = ERROR_MESSAGE_INVALID_ORDER_NUMBER;
                return this.RedirectToAction("Index", "Home");
            }

            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(id);
            var orderProductsViewModel = this.mapper.Map<IList<OrderProductsViewModel>>(orderProducts);

            var orderViewModel = this.mapper.Map<OrderDetailsViewModel>(order);

            orderViewModel.OrderProductsViewModel = orderProductsViewModel;

            return this.View(orderViewModel);
        }
    }
}