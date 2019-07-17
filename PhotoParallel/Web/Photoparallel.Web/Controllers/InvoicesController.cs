namespace Photoparallel.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Invoices;

    public class InvoicesController : BaseController
    {
        private readonly IInvoicesService invoicesService;
        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;

        public InvoicesController(IInvoicesService invoicesService, IOrdersService ordersService, IMapper mapper)
        {
            this.invoicesService = invoicesService;
            this.ordersService = ordersService;
            this.mapper = mapper;
        }

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var invoice = await this.invoicesService.GetInvoiceByIdAsync(id);

            if (invoice == null || invoice.Customer.UserName != this.User.Identity.Name)
            {
                return this.RedirectToAction("My", "Orders");
            }

            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(invoice.Order.Id);
            var invoiceProductsViewModel = this.mapper.Map<IList<InvoiceOrderProductsViewModel>>(orderProducts);

            var invoiceViewModel = this.mapper.Map<InvoiceViewModel>(invoice);
            invoiceViewModel.InvoiceProducts = invoiceProductsViewModel;

            return this.View(invoiceViewModel);
        }
    }
}
