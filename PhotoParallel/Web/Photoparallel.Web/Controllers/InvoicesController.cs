namespace Photoparallel.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Invoices;
    using X.PagedList;

    public class InvoicesController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 15;

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

        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var invoice = await this.invoicesService.GetInvoiceByIdAsync(id);

            if (invoice == null || invoice.Customer.UserName != this.User.Identity.Name)
            {
                return this.View("InvoiceNotFound");
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

        [Authorize]
        public async Task<IActionResult> RentDetails(int id)
        {
            var invoice = await this.invoicesService.GetInvoiceByIdAsync(id);

            if (invoice == null || invoice.Customer.UserName != this.User.Identity.Name)
            {
                return this.View("InvoiceNotFound");
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

        [Authorize]
        public async Task<IActionResult> My(int? pageNumber, int? pageSize)
        {
            var allInvoices = await this.invoicesService.GetAllAsync();

            var allMyInvoices = allInvoices.Where(x => x.CustomerId == this.User.FindFirst(ClaimTypes.NameIdentifier).Value)
                .OrderByDescending(x => x.IssuedOn);

            var allMyInvoicesViewModel = this.mapper.Map<IList<MyInvoicesViewModel>>(allMyInvoices);

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageInvoicesViewModel = allMyInvoicesViewModel.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageInvoicesViewModel);
        }
    }
}
