namespace Photoparallel.Web.Controllers
{
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Products;

    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;
        private readonly IMapper mapper;

        public ProductsController(IProductsService productsService, IMapper mapper)
        {
            this.productsService = productsService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.NotFound();
            }

            var productViewModel = this.mapper.Map<DetailsProductViewModel>(product);

            return this.View(productViewModel);
        }
    }
}