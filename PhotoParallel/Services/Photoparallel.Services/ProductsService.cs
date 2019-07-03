namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;

    public class ProductsService : IProductsService
    {
        private readonly PhotoparallelDbContext context;

        public ProductsService(PhotoparallelDbContext context)
        {
            this.context = context;
        }

        public void AddImageUrls(int id, IEnumerable<string> imageUrls)
        {
            var product = this.context.Products.Include(x => x.Images)
                                          .FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return;
            }

            foreach (var imageUrl in imageUrls)
            {
                var image = new Image { ImageUrl = imageUrl };
                product.Images.Add(image);
            }

            this.context.SaveChanges();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                return;
            }

            this.context.Products.Add(product);
            this.context.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await this.context.Products
                .Include(x => x.Images)
                .OrderByDescending(x => x.Id)
                .ToListAsync();

            return products;
        }
    }
}
