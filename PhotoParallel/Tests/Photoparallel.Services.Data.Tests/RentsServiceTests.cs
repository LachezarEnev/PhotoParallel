namespace Photoparallel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Xunit;

    public class RentsServiceTests
    {
        [Fact]
        public async Task CreateOpenRentByUserIdAsyncShouldCreateOpenRent()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user = new ApplicationUser { UserName = "gosho@sth.bg" };

            var userService = new Mock<IUsersService>();
            userService.Setup(u => u.GetUserByUsername(user.UserName))
                .Returns(user);

            var productsService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productsService.Object);

            await rentsService.CreateOpenRentByUserIdAsync(user.UserName);

            var openRent = dbContext.Rents.ToList();

            Assert.Single(openRent);
            Assert.Equal(RentStatus.Open, openRent.First().RentStatus);
        }

        [Fact]
        public async Task GetOpenRentAsyncShouldReturnOpenRentByUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            dbContext.Add(user1);
            dbContext.Add(user2);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open, Customer = user1 },
               new Rent { RentStatus = RentStatus.Pending, Customer = user1 },
               new Rent { RentStatus = RentStatus.Rented, Customer = user1 },
               new Rent { RentStatus = RentStatus.Open, Customer = user2 },
               new Rent { RentStatus = RentStatus.Returned, Customer = user1 },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();
            userService.Setup(r => r.GetUserByUsername(user1.UserName))
                       .Returns(user1);

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var userRent = await rentsService.GetOpenRentAsync(user1.UserName);

            Assert.Equal(user1.UserName, userRent.Customer.UserName);
            Assert.Equal(RentStatus.Open, userRent.RentStatus);
        }

        [Fact]
        public async Task AddProductAsyncShouldAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };

            var userService = new Mock<IUsersService>();

            var productId = 1;
            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(productId))
                          .ReturnsAsync(new Product { Name = "Canon M50", PricePerDay = 100 });

            var invoicesService = new Mock<IInvoicesService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.AddProductAsync(productId, rent);

            var rentProducts = dbContext.RentProducts.ToList();

            Assert.Single(rentProducts);
            Assert.Equal(rent.Id, rentProducts.First().RentId);
        }

        [Fact]
        public async Task AddProductAsyncWithInvalidProductShouldNotAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };

            var userService = new Mock<IUsersService>();

            var productId = 1;
            Product product = null;
            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(productId))
                          .ReturnsAsync(product);

            var invoicesService = new Mock<IInvoicesService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.AddProductAsync(productId, rent);

            var rentProducts = dbContext.RentProducts.ToList();

            Assert.Empty(rentProducts);
        }

        [Fact]
        public async Task AddProductAsyncWithExistingProductShouldNotIncreaseProductQuantity()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };

            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", PricePerDay = 100 };
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(product.Id))
                          .ReturnsAsync(product);

            var invoicesService = new Mock<IInvoicesService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.AddProductAsync(product.Id, rent);

            await rentsService.AddProductAsync(product.Id, rent);

            var rentProducts = dbContext.RentProducts.ToList();

            Assert.Single(rentProducts);
            Assert.Equal(1, rentProducts.First().Quantity);
        }

        [Fact]
        public async Task DeleteProductAsyncShouldDeleteProductfromRent()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var products = new List<Product>
            {
               new Product { Name = "Canon M50" },
               new Product { Name = "Phanyom 4" },
               new Product { Name = "Vanguard bag" },
               new Product { Name = "Ikan SM" },
            };
            dbContext.Products.AddRange(products);

            var rentProducts = new List<RentProduct>
            {
                new RentProduct { Product = products.First() },
                new RentProduct { Product = products.Last() },
            };

            rent.Products = rentProducts;
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);
            var delereProductId = rentProducts.First().Product.Id;
            await rentsService.DeleteProductAsync(delereProductId, rent);

            var openRentProducts = dbContext.RentProducts.ToList();

            Assert.Single(openRentProducts);
        }

        [Fact]
        public async Task DeleteProductAsyncShouldNotDeleteProductWithInvalidProductId()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var products = new List<Product>
            {
               new Product { Name = "Canon M50" },
               new Product { Name = "Phanyom 4" },
               new Product { Name = "Vanguard bag" },
               new Product { Name = "Ikan SM" },
            };
            dbContext.Products.AddRange(products);

            var rentProducts = new List<RentProduct>
            {
                new RentProduct { Product = products.First() },
                new RentProduct { Product = products.Last() },
            };

            rent.Products = rentProducts;
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);
            var delereProductId = 1000;
            await rentsService.DeleteProductAsync(delereProductId, rent);

            var openRentProducts = dbContext.RentProducts.ToList();

            Assert.Equal(2, openRentProducts.Count());
        }

        [Fact]
        public async Task GetAllRentsByUserAsyncShouldReturnAllRentssWhithoutOpenRentByUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open, Customer = user1 },
               new Rent { RentStatus = RentStatus.Pending, Customer = user1 },
               new Rent { RentStatus = RentStatus.Rented, Customer = user1 },
               new Rent { RentStatus = RentStatus.Open, Customer = user2 },
               new Rent { RentStatus = RentStatus.Returned, Customer = user1 },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var allRents = await rentsService.GetAllRentsByUserAsync(user1.UserName);

            Assert.Equal(3, allRents.Count());
        }

        [Fact]
        public async Task GetRentByIdAsyncShouldReturnRentWhichIsNotOpen()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Pending };

            dbContext.Rents.Add(rent);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var searchedRent = await rentsService.GetRentByIdAsync(rent.Id);

            Assert.Equal(rent.Id, searchedRent.Id);
        }

        [Fact]
        public async Task GetRentByIdAsyncShouldNotReturnRentWhichIsOpen()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };

            dbContext.Rents.Add(rent);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var searchedRent = await rentsService.GetRentByIdAsync(rent.Id);

            Assert.Null(searchedRent);
        }

        [Fact]
        public async Task RentProductsByRentIdAsyncShouldReturnAllOrderProductsInTheOrder()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var products = new List<Product>
            {
               new Product { Name = "Canon M50" },
               new Product { Name = "Phanyom 4" },
               new Product { Name = "Vanguard bag" },
               new Product { Name = "Ikan SM" },
            };
            dbContext.Products.AddRange(products);

            var rentProducts = new List<RentProduct>
            {
                new RentProduct { Product = products.First(), Quantity = 1 },
                new RentProduct { Product = products.Last(), Quantity = 1 },
            };

            rent.Products = rentProducts;
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var rentdProducts = await rentsService.RentProductsByRentIdAsync(rent.Id);

            Assert.Equal(2, rentdProducts.Count());
        }

        [Fact]
        public async Task GetPendingRentsAsyncShouldReturnAllPendingRents()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open },
               new Rent { RentStatus = RentStatus.Pending },
               new Rent { RentStatus = RentStatus.Denied },
               new Rent { RentStatus = RentStatus.Pending },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Rented },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var pendingRents = await rentsService.GetPendingRentsAsync();

            Assert.Equal(2, pendingRents.Count());
        }

        [Fact]
        public async Task GetRentedRentsAsyncShouldReturnAllRentedRents()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open },
               new Rent { RentStatus = RentStatus.Pending },
               new Rent { RentStatus = RentStatus.Denied },
               new Rent { RentStatus = RentStatus.Rented },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Rented },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var rentedRents = await rentsService.GetRentedRentsAsync();

            Assert.Equal(2, rentedRents.Count());
        }

        [Fact]
        public async Task GetDeniedRentsAsyncShouldReturnAllDeniedRents()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open },
               new Rent { RentStatus = RentStatus.Pending },
               new Rent { RentStatus = RentStatus.Denied },
               new Rent { RentStatus = RentStatus.Rented },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Denied },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var deniedRents = await rentsService.GetDeniedRentsAsync();

            Assert.Equal(2, deniedRents.Count());
        }

        [Fact]
        public async Task GetReturnedRentsAsyncShouldReturnAllReturnedRents()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open },
               new Rent { RentStatus = RentStatus.Pending },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Rented },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Denied },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var returnedRents = await rentsService.GetReturnedRentsAsync();

            Assert.Equal(2, returnedRents.Count());
        }

        [Fact]
        public async Task GetPendingRentsAsyncShouldReturnNothingIfNoPendingRentss()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rents = new List<Rent>
            {
               new Rent { RentStatus = RentStatus.Open },
               new Rent { RentStatus = RentStatus.Rented },
               new Rent { RentStatus = RentStatus.Denied },
               new Rent { RentStatus = RentStatus.Denied },
               new Rent { RentStatus = RentStatus.Returned },
               new Rent { RentStatus = RentStatus.Rented },
            };
            dbContext.Rents.AddRange(rents);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            var pendingRents = await rentsService.GetPendingRentsAsync();

            Assert.Empty(pendingRents);
        }

        [Fact]
        public async Task ShipAsyncShouldChangePendingStatusToShipped()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Pending };

            dbContext.Rents.Add(rent);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.ShipAsync(rent.Id);

            Assert.Equal(RentStatus.Rented, rent.RentStatus);
        }

        [Theory]
        [InlineData(RentStatus.Returned, RentStatus.Returned)]
        [InlineData(RentStatus.Open, RentStatus.Open)]
        [InlineData(RentStatus.Rented, RentStatus.Rented)]
        [InlineData(RentStatus.Denied, RentStatus.Denied)]
        public async Task ShipAsyncShouldNotChangeStatusToShippedIfStatusIdDifferentThanPending(RentStatus rentStatus, RentStatus expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = rentStatus };

            dbContext.Rents.Add(rent);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.ShipAsync(rent.Id);

            Assert.Equal(expected, rent.RentStatus);
        }

        [Fact]
        public async Task SetRentDetailsAsyncShouldUpdateRent()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };

            dbContext.Rents.Add(rent);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);
            rent.ShippingAddress = "Sofia, Mladost 4";
            rent.RecipientPhoneNumber = "0877777777";

            await rentsService.SetRentDetailsAsync(rent);

            Assert.Equal("Sofia, Mladost 4", rent.ShippingAddress);
            Assert.Equal("0877777777", rent.RecipientPhoneNumber);
        }

        [Theory]
        [InlineData(1, false, RentStatus.Pending, true, 0)]
        [InlineData(3, false, RentStatus.Pending, false, 2)]        
        public async Task FinishRentAsyncShouldChangeStatusToPendingAndReduceProductQuantity(int productQuantity, bool isRented, RentStatus expectedStatus, bool expextedIsRented, int expectedProductQuantity)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = RentStatus.Open };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Quantity = productQuantity, IsRented = isRented };

            dbContext.Products.Add(product);

            var rentProduct = new RentProduct { Product = product, Quantity = 1 };

            rent.Products.Add(rentProduct);
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.FinishRentAsync(rent);

            Assert.Equal(expectedStatus, rent.RentStatus);
            Assert.Equal(expextedIsRented, product.IsRented);
            Assert.Equal(expectedProductQuantity, product.Quantity);
        }

        [Theory]
        [InlineData(0, true, RentStatus.Pending, RentStatus.Denied, false, 1)]
        [InlineData(3, true, RentStatus.Pending, RentStatus.Denied, false, 4)]
        [InlineData(1, false, RentStatus.Open, RentStatus.Open, false, 1)]
        [InlineData(0, true, RentStatus.Rented, RentStatus.Rented, true, 0)]
        public async Task DeleteRentAsyncShouldChangePendingStatusToDenied(int productQuantity, bool isRented, RentStatus rentStatus, RentStatus expectedStatus, bool expextedIsRented, int expectedProductQuantity)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = rentStatus };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Quantity = productQuantity, IsRented = isRented };

            dbContext.Products.Add(product);

            var rentProduct = new RentProduct { Product = product, Quantity = 1 };

            rent.Products.Add(rentProduct);
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.DeleteRentAsync(rent.Id);

            Assert.Equal(expectedStatus, rent.RentStatus);
            Assert.Equal(expextedIsRented, product.IsRented);
            Assert.Equal(expectedProductQuantity, product.Quantity);
        }

        [Theory]
        [InlineData(0, true, RentStatus.Rented, 0, ReturnedOnTime.Yes, RentStatus.Returned, false, 1, 0)]
        [InlineData(3, false, RentStatus.Rented, 100, ReturnedOnTime.No, RentStatus.Returned, false, 4, 100)]
        [InlineData(1, false, RentStatus.Open, 0, ReturnedOnTime.Yes, RentStatus.Open, false, 1, 0)]
        [InlineData(0, true, RentStatus.Pending, 50, ReturnedOnTime.Yes, RentStatus.Pending, true, 0, 0)]
        public async Task ReturnAsyncShouldChangeRentedStatusToReturned(int productQuantity, bool isRented, RentStatus rentStatus, decimal penalty, ReturnedOnTime returnedOnTime, RentStatus expectedStatus, bool expextedIsRented, int expectedProductQuantity, decimal expectedPenalty)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var rent = new Rent { RentStatus = rentStatus };
            dbContext.Rents.Add(rent);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Quantity = productQuantity, IsRented = isRented };

            dbContext.Products.Add(product);

            var rentProduct = new RentProduct { Product = product, Quantity = 1 };

            rent.Products.Add(rentProduct);
            await dbContext.SaveChangesAsync();

            var rentsService = new RentsService(dbContext, userService.Object, invoicesService.Object, productService.Object);

            await rentsService.ReturnAsync(rent.Id, penalty, returnedOnTime);

            Assert.Equal(expectedStatus, rent.RentStatus);
            Assert.Equal(expextedIsRented, product.IsRented);
            Assert.Equal(expectedProductQuantity, product.Quantity);
            Assert.Equal(expectedPenalty, rent.Penalty);           
        }
    }
}
