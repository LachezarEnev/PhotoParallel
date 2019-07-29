namespace Photoparallel.Web.Areas.Administration.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Photoparallel.Common;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;
    using Photoparallel.Web.Areas.Administration.ViewModels.Products;
    using X.PagedList;

    public class ProductsController : AdministrationController
    {
        private const int DefaultPageNumber = 1;
        private const int DefaultPageSize = 10;

        private readonly IMapper mapper;
        private readonly IImagesService imagesService;
        private readonly IProductsService productsService;

        public ProductsController(IMapper mapper, IImagesService imagesService, IProductsService productsService)
        {
            this.mapper = mapper;
            this.imagesService = imagesService;
            this.productsService = productsService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductsInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var product = this.mapper.Map<Product>(model);

            await this.productsService.AddProductAsync(product);

            if (model.FormImages != null)
            {
                int existingImages = 0;
                var imageUrls = await this.imagesService.UploadImagesAsync(model.FormImages.ToList(), existingImages, GlobalConstants.ProcuctPathTemplate, product.Id);

                await this.productsService.AddImageUrlsAsync(product.Id, imageUrls);
            }

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> All(int? pageNumber, int? pageSize)
        {
            var products = await this.productsService.GetAllProductsAsync();

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageProductsViewMode = products.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageProductsViewMode);
        }

        public async Task<IActionResult> Rent(int? pageNumber, int? pageSize)
        {
            var products = await this.productsService.GetRentProductsAsync();

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageProductsViewMode = products.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageProductsViewMode);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.RedirectToAction("All");
            }

            var model = this.mapper.Map<EditProductsInputModel>(product);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditProductsInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var product = this.mapper.Map<Product>(model);

            await this.productsService.EditProductAsync(product);

            if (model.FormImages != null)
            {
                int existingImages = this.productsService.GetImages(product.Id).Count();
                var imageUrls = await this.imagesService.UploadImagesAsync(model.FormImages.ToList(), existingImages, GlobalConstants.ProcuctPathTemplate, product.Id);

                await this.productsService.AddImageUrlsAsync(product.Id, imageUrls);
            }

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Hide(int id)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.RedirectToAction("All");
            }

            var hideViewModel = this.mapper.Map<HideProductsViewModel>(product);

            return this.View(hideViewModel);
        }

        [HttpPost]
        public IActionResult HideConfirmed(int id)
        {
            this.productsService.HideProduct(id);

            return this.RedirectToAction("Hidden");
        }

        public async Task<IActionResult> Show(int id)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.RedirectToAction("Hidden");
            }

            var showViewModel = this.mapper.Map<HideProductsViewModel>(product);

            return this.View(showViewModel);
        }

        [HttpPost]
        public IActionResult ShowConfirmed(int id)
        {
            this.productsService.ShowProduct(id);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Hidden(int? pageNumber, int? pageSize)
        {
            var products = await this.productsService.GetHiddenProductsAsync();

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageProductsViewMode = products.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageProductsViewMode);
        }

        public async Task<IActionResult> Oos(int? pageNumber, int? pageSize)
        {
            var products = await this.productsService.GetOosProductsAsync();

            pageNumber = pageNumber ?? DefaultPageNumber;
            pageSize = pageSize ?? DefaultPageSize;
            var pageProductsViewMode = products.ToPagedList(pageNumber.Value, pageSize.Value);

            return this.View(pageProductsViewMode);
        }

        public async Task<IActionResult> Supply(int id)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

            if (product == null)
            {
                return this.RedirectToAction("All");
            }

            var productViewModel = new ProductsSupplyInputModel() { Name = product.Name, Id = product.Id };

            return this.View(productViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Supply(ProductsSupplyInputModel model)
        {
            await this.productsService.AddQuantityAsync(model.Id, model.Quantity);

            return this.RedirectToAction("All");
        }
    }
}