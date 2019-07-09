namespace Photoparallel.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Orders;

    public class OrdersController : BaseController
    {
        private const int DefaultProductQuantity = 1;

        private readonly IOrdersService ordersService;
        private readonly IProductsService productsService;
        private readonly IMapper mapper;

        public OrdersController(IOrdersService ordersService, IProductsService productsService, IMapper mapper)
        {
            this.ordersService = ordersService;
            this.productsService = productsService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Add(int id)
        {
            if (!this.User.Identity.IsAuthenticated)
            {
                return this.Redirect("/Identity/Account/Login");
            }

            List<OpenOrdersProductsViewModel> orderProducts = new List<OpenOrdersProductsViewModel>();

            var openOrder = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);

            await this.ordersService.AddProductAsync(id, openOrder);

            foreach (var product in openOrder.Products)
            {
                var productOrder = await this.ordersService.GetOrderProductAsync(product.ProductId, openOrder);
                var orderProduct = this.mapper.Map<OpenOrdersProductsViewModel>(product.Product);

                orderProduct.OrderQuantity = productOrder.Quantity;
                orderProduct.TotalPrice = orderProduct.OrderQuantity * orderProduct.Price;

                orderProducts.Add(orderProduct);
            }

            return this.View(orderProducts);
        }
    }
}
