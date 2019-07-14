namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
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

        public async Task<IActionResult> Details(int id)
        {
            var order = await this.ordersService.GetOrderByIdAsync(id);

            if (order == null)
            {
                this.TempData["error"] = GlobalConstants.ErrorMessageInvalidOrderNumber;
                return this.RedirectToAction("/Home/Index/");
            }

            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(id);
            var orderProductsViewModel = this.mapper.Map<IList<OrderProductsViewModel>>(orderProducts);

            var orderViewModel = this.mapper.Map<OrderDetailsViewModel>(order);
            orderViewModel.OrderProductsViewModel = orderProductsViewModel;

            if (order.OrderStatus == OrderStatus.Pending || order.OrderStatus == OrderStatus.Denied)
            {
                orderViewModel.EstimatedDeliveryDate = "N/A";
            }
            else if (order.OrderStatus == OrderStatus.Approved)
            {
                orderViewModel.EstimatedDeliveryDate = "N/A";
            }
            else if (order.OrderStatus == OrderStatus.Delivered)
            {
                orderViewModel.EstimatedDeliveryDate = "Delivered";
            }
            else
            {
                orderViewModel.EstimatedDeliveryDate = order.EstimatedDeliveryDate?.ToString(@"dd/MM/yyyy");
            }

            return this.View(orderViewModel);
        }
    }
}