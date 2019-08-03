namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;
    using Photoparallel.Web.Areas.Administration.ViewModels.Orders;

    public class OrdersController : AdministrationController
    {
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

        public async Task<IActionResult> Waiting()
        {
            var orders = await this.ordersService.GetWaitingOrdersAsync();

            var waitingOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(waitingOrders);
        }

        public async Task<IActionResult> Approved()
        {
            var orders = await this.ordersService.GetApprovedOrdersAsync();

            var allApprovedOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allApprovedOrders);
        }

        public async Task<IActionResult> Shipped()
        {
            var orders = await this.ordersService.GetShippedOrdersAsync();

            var allShippedOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allShippedOrders);
        }

        public async Task<IActionResult> Delivered()
        {
            var orders = await this.ordersService.GetDeliveredOrdersAsync();

            var allDeliveredOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allDeliveredOrders);
        }

        public async Task<IActionResult> Denied()
        {
            var orders = await this.ordersService.GetDeniedOrdersAsync();

            var allDeniedOrders = this.mapper.Map<IList<AllOrdersViewModel>>(orders);

            return this.View(allDeniedOrders);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);

            if (order == null)
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

        public async Task<IActionResult> Approve(int id)
        {
            await this.ordersService.ApproveAsync(id);

            return this.RedirectToAction("Pending");
        }

        public async Task<IActionResult> Ship(int id)
        {
            await this.ordersService.ShipAsync(id);

            return this.RedirectToAction("Approved");
        }

        public async Task<IActionResult> Deliver(int id)
        {
            await this.ordersService.DeliverAsync(id);

            return this.RedirectToAction("Shipped");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);

            if (order == null)
            {
                return this.View("OrderNotFound");
            }

            var orderViewModel = this.mapper.Map<DeleteOrderViewModel>(order);

            return this.View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.ordersService.DeleteOrderAsync(id);

            return this.RedirectToAction("Denied");
        }
    }
}