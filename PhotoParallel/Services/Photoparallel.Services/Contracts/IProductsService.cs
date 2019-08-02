namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;

    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task AddImageUrlsAsync(int id, IEnumerable<string> imageUrls);

        Task AddProductAsync(Product product);

        Task<Product> GetProductByIdAsync(int id);

        Task<bool> EditProductAsync(Product product);

        IEnumerable<Image> GetImages(int id);

        bool HideProduct(int id);

        bool ShowProduct(int id);

        Task<IEnumerable<Product>> GetVisibleProductsAsync();

        Task<IEnumerable<Product>> GetVisibleProductsByTypeAsync(string productType);

        Task<IEnumerable<Product>> GetHiddenProductsAsync();

        Task<IEnumerable<Product>> GetOosProductsAsync();

        Task<IEnumerable<Product>> GetProductsFilterAsync(string searchString, string productType);

        Task<IEnumerable<Product>> GetProductsBySearchAsync(string searchString);

        Task<IEnumerable<Product>> GetRentProductsAsync();

        IEnumerable<Product> OrderBy(IEnumerable<Product> products, ProductsSort sortBy);

        Task AddQuantityAsync(int id, int quantity);
    }
}
