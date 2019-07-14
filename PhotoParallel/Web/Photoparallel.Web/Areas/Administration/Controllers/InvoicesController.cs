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

        public async Task<IActionResult> Create(int id)
        {
            await this.invoicesService.CreateAsync(id);

            return this.RedirectToAction("All", "Orders");
        }
    }
}
