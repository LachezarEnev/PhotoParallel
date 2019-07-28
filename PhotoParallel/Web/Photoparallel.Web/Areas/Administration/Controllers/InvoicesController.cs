namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Invoices;

    public class InvoicesController : AdministrationController
    {
        private readonly IInvoicesService invoicesService;
        private readonly IOrdersService ordersService;
        private readonly IMapper mapper;
        private readonly IRentsService rentsService;

        public InvoicesController(IInvoicesService invoicesService, IOrdersService ordersService, IMapper mapper, IRentsService rentsService)
        {
            this.invoicesService = invoicesService;
            this.ordersService = ordersService;
            this.mapper = mapper;
            this.rentsService = rentsService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var invoice = await this.invoicesService.GetInvoiceByIdAsync(id);

            if (invoice == null)
            {
                return this.RedirectToAction("My", "Invoices");
            }

            if (invoice.Order == null)
            {
                return this.RedirectToAction("RentDetails", new { id = invoice.Id });
            }

            var orderProducts = await this.ordersService.OrderProductsByOrderIdAsync(invoice.Order.Id);
            var invoiceProductsViewModel = this.mapper.Map<IList<InvoiceOrderProductsViewModel>>(orderProducts);

            var invoiceViewModel = this.mapper.Map<InvoiceViewModel>(invoice);
            invoiceViewModel.InvoiceProducts = invoiceProductsViewModel;

            return this.View(invoiceViewModel);
        }

        public async Task<IActionResult> RentDetails(int id)
        {
            var invoice = await this.invoicesService.GetInvoiceByIdAsync(id);

            if (invoice == null)
            {
                return this.RedirectToAction("My", "Invoices");
            }

            if (invoice.Rent == null)
            {
                return this.RedirectToAction("Details", new { id = invoice.Id });
            }

            var rentProducts = await this.rentsService.RentProductsByRentIdAsync(invoice.Rent.Id);
            var invoiceProductsViewModel = this.mapper.Map<IList<InvoiceRentProductsViewModel>>(rentProducts);

            var rentProduct = rentProducts.FirstOrDefault();
            var days = (int)(rentProduct.Rent.ReturnDate - rentProduct.Rent.RentDate).TotalDays;

            var invoiceViewModel = this.mapper.Map<InvoiceRentViewModel>(invoice);
            invoiceViewModel.Days = days;
            invoiceViewModel.InvoiceProducts = invoiceProductsViewModel;

            return this.View(invoiceViewModel);
        }
    }
}
