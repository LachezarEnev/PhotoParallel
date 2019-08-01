namespace Photoparallel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Xunit;

    public class ProductsServiceTests
    {
        [Fact]
        public async Task AddProductAsyncShouldAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var product = new Product { Name = "Canon M50" };
            await productService.AddProductAsync(product);

            var products = dbContext.Products.ToList();

            Assert.Single(products);
            Assert.Equal(product.Name, products.First().Name);
        }

        [Fact]
        public async Task AddProductAsyncNullEntityShouldNotAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            Product product = null;
            await productService.AddProductAsync(product);

            var products = dbContext.Products.ToList();

            Assert.Empty(products);
        }

        [Fact]
        public void HideProductShouldChangeHiteToTrue()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                     .UseInMemoryDatabase(Guid.NewGuid().ToString())
                     .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var productName = "Canon M50";
            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = productName },
                new Product { Name = "Phantom 4" },
                new Product { Name = "Ikan" },
                new Product { Name = "SanDisk" },
            });
            dbContext.SaveChanges();

            var product = dbContext.Products.FirstOrDefault(x => x.Name == productName);

            var isProductHide = productService.HideProduct(product.Id);

            Assert.True(isProductHide);
            Assert.True(product.Hide);
        }

        [Fact]
        public void ShowProductShouldChangeHiteToFalse()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var productName = "Canon M50";
            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = productName, Hide = true },
                new Product { Name = "Phantom 4" },
                new Product { Name = "Ikan" },
                new Product { Name = "SanDisk" },
            });
            dbContext.SaveChanges();

            var product = dbContext.Products.FirstOrDefault(x => x.Name == productName);

            var isProductShow = productService.ShowProduct(product.Id);

            Assert.True(isProductShow);
            Assert.False(product.Hide);
        }

        [Fact]
        public void HideInvalidProducShouldReturnFalse()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50" },
                new Product { Name = "Phantom 4" },
                new Product { Name = "Ikan" },
                new Product { Name = "SanDisk" },
            });
            dbContext.SaveChanges();

            var invalidProductId = 5;
            var isProductDeleted = productService.HideProduct(invalidProductId);

            Assert.False(isProductDeleted);
        }

        [Theory]
        [InlineData("Canon", 3)]
        [InlineData("Dji", 0)]
        [InlineData("Lens", 1)]
        [InlineData("m", 3)]
        public async Task GetProductsBySearchAsyncShouldReturnSaleProductsBySearch(string searchString, int expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                     .UseInMemoryDatabase(Guid.NewGuid().ToString())
                     .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            await dbContext.SaveChangesAsync();

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale },
                new Product { Name = "canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetProductsBySearchAsync(searchString);

            Assert.Equal(expected, products.Count());
        }

        [Fact]
        public async Task GetVisibleProductsAsyncShouldReturnAllVisibleProductsForSale()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale },
                new Product { Name = "canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Sale, Hide = true },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetVisibleProductsAsync();

            Assert.Equal(4, products.Count());
            Assert.DoesNotContain(products, x => x.Hide == true);
        }

        [Fact]
        public async Task GetHiddenProductsAsyncShouldReturnAllHiddenProducts()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50" },
                new Product { Name = "Canon EOS200" },
                new Product { Name = "Ikan Ms", Hide = true },
                new Product { Name = "canon Ef-M 55-200 lens" },
                new Product { Name = "Dji Phantom 4", Hide = true },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetHiddenProductsAsync();

            Assert.Equal(2, products.Count());
            Assert.DoesNotContain(products, x => x.Hide == false);
        }

        [Fact]
        public async Task GetAllProductsAsyncShouldReturnAllForSale()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Rent },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale, Hide = true },
                new Product { Name = "canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Sale, Hide = true },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetAllProductsAsync();

            Assert.Equal(4, products.Count());
        }

        [Fact]
        public async Task GetRentProductsAsyncShouldReturnVisibleProductsForRent()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Rent },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Rent },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Rent, Hide = true },
                new Product { Name = "canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale },
                new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Sale, Hide = true },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetRentProductsAsync();

            Assert.Equal(2, products.Count());
        }

        [Fact]
        public async Task GetProductByIdAsyncShouldReturnProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var productName = "Canon M50";
            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = productName },
                new Product { Name = "Canon EOS200" },
                new Product { Name = "Ikan Ms" },
                new Product { Name = "canon Ef-M 55-200 lens" },
                new Product { Name = "Dji Phantom 4" },
            });
            await dbContext.SaveChangesAsync();

            var productId = dbContext.Products.FirstOrDefault(x => x.Name == productName).Id;
            var product = await productService.GetProductByIdAsync(productId);

            Assert.Equal(productName, product.Name);
        }

        [Fact]
        public async Task GetOosProductsAsyncShouldReturnAllOosProductsForSale()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
               new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale, Quantity = 0, InPendingOrders = 0 },
               new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Sale, Quantity = 1, InPendingOrders = 2 },
               new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale, Quantity = 0, InPendingOrders = 1 },
               new Product { Name = "canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale, Quantity = 2, InPendingOrders = 1 },
               new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Sale,  Quantity = 2, InPendingOrders = 2 },
            });
            dbContext.SaveChanges();

            var products = await productService.GetOosProductsAsync();

            Assert.Equal(4, products.Count());
        }

        [Fact]
        public async Task GetVisibleProductsByTypeAsyncShouldReturnAllVisibleProductsForSaleByType()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera, Hide = true },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Stand },
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Rent, ProductType = ProductType.Camera },
                new Product { Name = "Canon EOS 200", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera },
                new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Drone },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetVisibleProductsByTypeAsync("Camera");

            Assert.Equal(2, products.Count());
            Assert.DoesNotContain(products, x => x.Hide == true);
        }

        [Fact]
        public async Task EditProductAsynctShouldEditProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
               .UseInMemoryDatabase(Guid.NewGuid().ToString())
               .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var product = new Product
            {
                Name = "Canon M50",
                Price = 1199,
                Warranty = 1,
            };

            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            product.Name = "Canon EOS M50";
            product.Price = 1100;
            product.Warranty = 2;
            await productService.EditProductAsync(product);

            var editedProduct = dbContext.Products.FirstOrDefault(x => x.Name == product.Name);

            Assert.Equal(product.Name, editedProduct.Name);
            Assert.Equal(product.Price, editedProduct.Price);
            Assert.Equal(product.Warranty, editedProduct.Warranty);
        }

        [Fact]
        public async Task AddImageUrlsAsyncShouldAddImageUrls()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var productName = "Canon M50";
            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = productName },
                new Product { Name = "Canon EOS200" },
                new Product { Name = "Ikan Ms" },
                new Product { Name = "canon Ef-M 55-200 lens" },
                new Product { Name = "Dji Phantom 4" },
            });
            await dbContext.SaveChangesAsync();

            var productId = dbContext.Products.FirstOrDefault(x => x.Name == productName).Id;
            var imageUrls = new List<string> { "wwwroot/image1", "wwwroot/image2", "wwwroot/image3" };
            await productService.AddImageUrlsAsync(productId, imageUrls);

            var product = dbContext.Products.FirstOrDefault(x => x.Id == productId);

            Assert.Equal(3, product.Images.Count);
        }

        [Fact]
        public async Task GetImagesShouldReturnImageUrls()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var product = new Product
            {
                Name = "Canon M50",
            };

            product.Images = new List<Image>
            {
                new Image { ImageUrl = "wwwroot/image1" },
                new Image { ImageUrl = "wwwroot/image2" },
            };

            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            var productImagesCount = productService.GetImages(product.Id).Count();

            Assert.Equal(2, productImagesCount);
        }

        [Fact]
        public void GetImagesWhithInvalidProductShouldReturnNull()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var invalidProductId = 123;
            var images = productService.GetImages(invalidProductId);

            Assert.Null(images);
        }

        [Theory]
        [InlineData(ProductsSort.Newest, "Canon M50")]
        [InlineData(ProductsSort.Name, "Bag Vanguard")]
        [InlineData(ProductsSort.PriceAscending, "Rode Videomic")]
        [InlineData(ProductsSort.PriceDescending, "Dji Phantom 4")]
        public async Task OrderByShouldOrderProducts(ProductsSort productsSort, string productName)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Bag Vanguard", Price = 180, ProductStatus = ProductStatus.Sale },
                new Product { Name = "Rode Videomic", Price = 150, ProductStatus = ProductStatus.Sale },
                new Product { Name = "Dji Phantom 4", Price = 3000, ProductStatus = ProductStatus.Sale },
                new Product { Name = "Canon M50", Price = 1199, ProductStatus = ProductStatus.Sale },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetVisibleProductsAsync();
            var orderedProducts = productService.OrderBy(products, productsSort);

            Assert.Equal(productName, orderedProducts.First().Name);
        }

        [Theory]
        [InlineData(3, null, "Camera")]
        [InlineData(1, "Canon M50", null)]
        [InlineData(4, "Canon", null)]
        [InlineData(0, "Phantom", null)]
        [InlineData(0, null, "Bag")]
        [InlineData(5, null, null)]
        public async Task GetProductsFilterAsyncShouldFilterProductsForSale(int expected, string searchString, string productType)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
              .UseInMemoryDatabase(Guid.NewGuid().ToString())
              .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            dbContext.Products.AddRange(new List<Product>
            {
                new Product { Name = "Canon M50", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera },
                new Product { Name = "Canon EOS200", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera, Hide = true },
                new Product { Name = "Ikan Ms", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Stand },
                new Product { Name = "Canon EOS M5", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera },
                new Product { Name = "Canon EOS 200", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Camera },
                new Product { Name = "Canon Ef-M 55-200 lens", ProductStatus = ProductStatus.Sale, ProductType = ProductType.Lens },
                new Product { Name = "Dji Phantom 4", ProductStatus = ProductStatus.Rent, ProductType = ProductType.Drone },
            });
            await dbContext.SaveChangesAsync();

            var products = await productService.GetProductsFilterAsync(searchString, productType);

            Assert.Equal(expected, products.Count());
        }

        [Fact]
        public async Task AddQuantityAsyncShouldAddQuoantitiesToProductQuantity()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var productService = new ProductsService(dbContext);

            var product = new Product()
            {
                Name = "Canon M50",
                Quantity = 5,
            };

            dbContext.Add(product);
            await dbContext.SaveChangesAsync();

            var productId = product.Id;

            await productService.AddQuantityAsync(productId, 5);

            Assert.Equal(10, product.Quantity);
        }
    }
}
