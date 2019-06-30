namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Home;

    public class HomeController : AdministrationController
    {
        private readonly IOrdersService ordersService;

        public HomeController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        public IActionResult Index()
        {
            var orders = this.ordersService.GetAllOrders();

            var allOrders = new List<AllOrdersViewModel>();

            foreach (var order in orders)
            {
                var currentOrder = new AllOrdersViewModel()
                {
                    Id = order.Id,
                    OrderStatus = order.OrderStatus.ToString(),
                    CreatedOn = order.CreatedOn.ToString("dd/MM/yyyy"),
                };

                allOrders.Add(currentOrder);
            }

            return this.View(allOrders);
        }
    }
}