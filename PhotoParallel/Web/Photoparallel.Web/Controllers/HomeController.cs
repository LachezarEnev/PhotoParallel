namespace Photoparallel.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.ViewModels.Home;
    using X.PagedList;

    public class HomeController : BaseController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 8;

        private readonly IProductsService productsService;
        private readonly IMapper mapper;

        public HomeController(IProductsService productsService, IMapper mapper)
        {
            this.productsService = productsService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var products = await this.productsService.GetProductsFilterAsync(model.SearchString, model.ProductType);
            products = this.productsService.OrderBy(products, model.SortBy).ToList();

            var productsViewModel = this.mapper.Map<IList<IndexProductViewModel>>(products);
            var allProductsViewModel = this.mapper.Map<IList<AllProductsVieModel>>(products);

            int pageNumber = model.PageNumber ?? DefaultPageNumber;
            int pageSize = model.PageSize ?? DefaultPageSize;
            var pageProductsViewMode = productsViewModel.ToPagedList(pageNumber, pageSize);

            model.ProductsViewModel = pageProductsViewMode;
            model.Products = allProductsViewModel;

            return this.View(model);
        }

        public IActionResult Camera(IndexViewModel model)
        {
            model.ProductType = "Camera";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Lens(IndexViewModel model)
        {
            model.ProductType = "Lens";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Bag(IndexViewModel model)
        {
            model.ProductType = "Bag";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Drone(IndexViewModel model)
        {
            model.ProductType = "Drone";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Microphone(IndexViewModel model)
        {
            model.ProductType = "Microphone";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Stand(IndexViewModel model)
        {
            model.ProductType = "Stand";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Accessory(IndexViewModel model)
        {
            model.ProductType = "Accessory";

            return this.RedirectToAction("Index", model);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => this.View();
    }
}
