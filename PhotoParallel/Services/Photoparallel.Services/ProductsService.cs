namespace Photoparallel.Services
{
    using System;
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

        public bool EditProduct(Product product)
        {
            if (!this.ProductExists(product.Id))
            {
                return false;
            }

            this.context.Update(product);
            this.context.SaveChanges();

            return true;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var products = await this.context.Products
                .Include(x => x.Images)
                .OrderByDescending(x => x.Id)
                .ToListAsync();

            return products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await this.context.Products
                .Include(x => x.Images)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            return product;
        }

        public IEnumerable<Image> GetImages(int id)
        {
            var product = this.context.Products
                .Include(x => x.Images)
                .FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return null;
            }

            return product.Images.ToList();
        }

        public bool HideProduct(int id)
        {
            var product = this.context.Products
                .FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return false;
            }

            product.Hide = true;
            this.context.SaveChanges();

            return true;
        }

        public bool ShowProduct(int id)
        {
            var product = this.context.Products
                .FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return false;
            }

            product.Hide = false;
            this.context.SaveChanges();

            return true;
        }

        private bool ProductExists(int id)
        {
            return this.context.Products.Any(e => e.Id == id);
        }
    }
}
