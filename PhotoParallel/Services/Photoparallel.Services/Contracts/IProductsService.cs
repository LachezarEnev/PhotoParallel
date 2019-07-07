namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;

    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();

        void AddImageUrls(int id, IEnumerable<string> imageUrls);

        void AddProduct(Product product);

        Task<Product> GetProductByIdAsync(int id);

        bool EditProduct(Product product);

        IEnumerable<Image> GetImages(int id);

        bool HideProduct(int id);

        bool ShowProduct(int id);

        Task<IEnumerable<Product>> GetHiddenProductsAsync();

        Task<IEnumerable<Product>> GetOosProductsAsync();

        Task<IEnumerable<Product>> GetProductsFilterAsync(string searchString);

        IEnumerable<Product> OrderBy(IEnumerable<Product> products, ProductsSort sortBy);
    }
}
