namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class ProductsController : AdministrationController
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}