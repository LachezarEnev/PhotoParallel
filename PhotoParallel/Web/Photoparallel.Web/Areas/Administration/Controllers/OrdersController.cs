namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;

    public class OrdersController : AdministrationController
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        public IActionResult All()
        {
            var orders = this.ordersService.GetAllOrders();

            var allOrders = new List<AllOrdersViewModel>();

            foreach (var order in orders)
            {
                var currentOrder = new AllOrdersViewModel()
                {
                    Id = order.Id,
                    CustomerFullName = order.Customer.FirstName + " " + order.Customer.LastName,
                    Status = order.OrderStatus.ToString(),
                    CreatedOn = order.CreatedOn.ToString("dd/MM/yyyy"),
                };

                allOrders.Add(currentOrder);
            }

            return this.View(allOrders);
        }

        public IActionResult Pending()
        {
            var orders = this.ordersService.GetPendingOrders();

            var allPendingOrders = new List<AllOrdersViewModel>();

            foreach (var order in orders)
            {
                var currentOrder = new AllOrdersViewModel()
                {
                    Id = order.Id,
                    CustomerFullName = order.Customer.FirstName + " " + order.Customer.LastName,
                    Status = order.OrderStatus.ToString(),
                    CreatedOn = order.CreatedOn.ToString("dd/MM/yyyy"),
                };

                allPendingOrders.Add(currentOrder);
            }

            return this.View(allPendingOrders);
        }
    }
}