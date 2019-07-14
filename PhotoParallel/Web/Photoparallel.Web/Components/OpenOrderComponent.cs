namespace Photoparallel.Web.Components
{
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Orders;

    public class OpenOrderComponent : ViewComponent
    {
        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;

        public OpenOrderComponent(IOrdersService ordersService, IMapper mapper)
        {
            this.ordersService = ordersService;
            this.mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var orderViewModel = new OpenOrderViewModel();

            var openOrder = await this.ordersService.GetOpenOrderByUserIdAsync(this.User.Identity.Name);
            orderViewModel.Id = openOrder.Id;

            foreach (var product in openOrder.Products)
            {
                var orderProductViewModel = this.mapper.Map<OpenOrdersProductsViewModel>(product.Product);

                orderProductViewModel.OrderQuantity = product.Quantity;
                orderProductViewModel.TotalPrice = product.TotalPrice;

                orderViewModel.Products.Add(orderProductViewModel);
            }

            return this.View(orderViewModel);
        }
    }
}
