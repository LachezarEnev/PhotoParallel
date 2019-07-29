namespace Photoparallel.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class CreditsController : BaseController
    {
        public async Task<IActionResult> Create(int id)
        {
            return this.View();
        }
    }
}
