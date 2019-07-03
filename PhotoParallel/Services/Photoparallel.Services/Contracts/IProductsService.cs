namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();

        void AddImageUrls(int id, IEnumerable<string> imageUrls);

        void AddProduct(Product product);
    }
}
