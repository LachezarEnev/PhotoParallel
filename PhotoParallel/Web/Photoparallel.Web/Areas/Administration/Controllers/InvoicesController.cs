namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;

    public class InvoicesController : AdministrationController
    {
        private readonly IInvoicesService invoicesService;

        public InvoicesController(IInvoicesService invoicesService)
        {
            this.invoicesService = invoicesService;
        }
    }
}
