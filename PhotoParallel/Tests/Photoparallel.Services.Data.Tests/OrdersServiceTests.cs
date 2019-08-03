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

    public class OrdersServiceTests
    {
        [Fact]
        public async Task AddProductAsyncShouldAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };

            var userService = new Mock<IUsersService>();

            var productId = 1;
            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(productId))
                          .ReturnsAsync(new Product { Name = "Canon M50", Price = 1199 });

            var invoicesService = new Mock<IInvoicesService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.AddProductAsync(productId, order);

            var orderProducts = dbContext.OrderProducts.ToList();

            Assert.Single(orderProducts);
            Assert.Equal(order.Id, orderProducts.First().OrderId);
        }

        [Fact]
        public async Task AddProductAsyncWithInvalidProductShouldNotAddProduct()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };

            var userService = new Mock<IUsersService>();

            var productId = 1;
            Product product = null;
            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(productId))
                          .ReturnsAsync(product);

            var invoicesService = new Mock<IInvoicesService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.AddProductAsync(productId, order);

            var orderProducts = dbContext.OrderProducts.ToList();

            Assert.Empty(orderProducts);
        }

        [Fact]
        public async Task AddProductAsyncWithExistingProductShouldIncreaseProductQuantity()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };

            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Price = 1199 };
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(product.Id))
                          .ReturnsAsync(product);

            var invoicesService = new Mock<IInvoicesService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.AddProductAsync(product.Id, order);

            await ordersService.AddProductAsync(product.Id, order);

            var orderProducts = dbContext.OrderProducts.ToList();

            Assert.Single(orderProducts);
            Assert.Equal(2, orderProducts.First().Quantity);
        }

        [Fact]
        public async Task DeleteProductAsyncShouldDeleteProductfromOrder()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };
            dbContext.Orders.Add(order);

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

            var orderProducts = new List<OrderProduct>
            {
                new OrderProduct { Product = products.First() },
                new OrderProduct { Product = products.Last() },
            };

            order.Products = orderProducts;
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);
            var delereProductId = orderProducts.First().Product.Id;
            await ordersService.DeleteProductAsync(delereProductId, order);

            var openOrderProducts = dbContext.OrderProducts.ToList();

            Assert.Single(openOrderProducts);
        }

        [Fact]
        public async Task DeleteProductAsyncShouldNotDeleteProductWithInvalidProductId()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var username = "gosho@sth.bg";
            var user = new ApplicationUser { UserName = username };

            var order = new Order { OrderStatus = OrderStatus.Open, Customer = user };
            dbContext.Orders.Add(order);

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

            var orderProducts = new List<OrderProduct>
            {
                new OrderProduct { Product = products.First() },
                new OrderProduct { Product = products.Last() },
            };

            order.Products = orderProducts;
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);
            var delereProductId = 5;
            await ordersService.DeleteProductAsync(delereProductId, order);

            var openOrderProducts = dbContext.OrderProducts.ToList();

            Assert.Equal(2, openOrderProducts.Count());
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        public async Task EditProductQuantityAsyncShoulChangeOrderProductQuantity(int quantity, int expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var username = "gosho@sth.bg";
            var user = new ApplicationUser { UserName = username };

            var order = new Order { OrderStatus = OrderStatus.Open, Customer = user };
            dbContext.Orders.Add(order);

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

            var orderProducts = new List<OrderProduct>
            {
                new OrderProduct { Product = products.First(), Quantity = 1 },
            };

            order.Products = orderProducts;
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);
            var orderProduct = orderProducts.First();
            var product = orderProduct.Product;
            await ordersService.EditProductQuantityAsync(product.Id, quantity, order);

            Assert.Equal(expected, orderProduct.Quantity);
        }

        [Fact]
        public async Task EditProductQuantityAsyncShouldDeleteOrderProductIfQuantityChangesToZero()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };
            dbContext.Orders.Add(order);

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

            var orderProducts = new List<OrderProduct>
            {
                new OrderProduct { Product = products.First(), Quantity = 1 },
            };

            order.Products = orderProducts;
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);
            var orderProduct = orderProducts.First();
            var product = orderProduct.Product;
            await ordersService.EditProductQuantityAsync(product.Id, 0, order);

            var allorderProducts = dbContext.OrderProducts.ToList();

            Assert.Empty(allorderProducts);
        }

        [Theory]
        [InlineData(99, 104)]
        [InlineData(150, 150)]
        public async Task AddShippingCostsToOrderAsyncShouldAddShippingCostsIfOrderAmountLessthan100BGN(int orderAmount, int expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Pending, TotalPrice = orderAmount };
            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.AddShippingCostsToOrderAsync(order.Id);

            Assert.Equal(expected, order.TotalPrice);
        }

        [Fact]
        public async Task GetAllOrdersAsyncShouldReturnAllOrdersWhithoutOpenOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Delivered },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var allOrders = await ordersService.GetAllOrdersAsync();

            Assert.Equal(5, allOrders.Count());
        }

        [Fact]
        public async Task GetAllOrdersByUserAsyncShouldReturnAllOrdersWhithoutOpenOrderByUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Pending, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Approved, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Delivered, Customer = user2 },
               new Order { OrderStatus = OrderStatus.Shipped, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Waiting, Customer = user2 },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var allOrders = await ordersService.GetAllOrdersByUserAsync(user1.UserName);

            Assert.Equal(3, allOrders.Count());
        }

        [Fact]
        public async Task GetOpenOrderByUserIdAsyncShouldReturnOpenOrderByUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            dbContext.Add(user1);
            dbContext.Add(user2);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Pending, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Approved, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Open, Customer = user2 },
               new Order { OrderStatus = OrderStatus.Shipped, Customer = user1 },
               new Order { OrderStatus = OrderStatus.Waiting, Customer = user2 },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();
            userService.Setup(r => r.GetUserByUsername(user1.UserName))
                       .Returns(user1);

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var userOrder = await ordersService.GetOpenOrderByUserIdAsync(user1.UserName);

            Assert.Equal(user1.UserName, userOrder.Customer.UserName);
            Assert.Equal(OrderStatus.Open, userOrder.OrderStatus);
        }

        [Fact]
        public async Task GetPendingOrdersAsyncShouldReturnAllPendingOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var pendingOrders = await ordersService.GetPendingOrdersAsync();

            Assert.Equal(2, pendingOrders.Count());
        }

        [Fact]
        public async Task GetWaitingOrdersAsyncShouldReturnAllWaitingOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Waiting },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var waitingOrders = await ordersService.GetWaitingOrdersAsync();

            Assert.Equal(2, waitingOrders.Count());
        }

        [Fact]
        public async Task GetApprovedOrdersAsyncShouldReturnAllApprovedOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Waiting },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Approved },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var approvedOrders = await ordersService.GetApprovedOrdersAsync();

            Assert.Equal(2, approvedOrders.Count());
        }

        [Fact]
        public async Task GetShippedOrdersAsyncShouldReturnAllShippedOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Approved },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var shippedOrders = await ordersService.GetShippedOrdersAsync();

            Assert.Equal(2, shippedOrders.Count());
        }

        [Fact]
        public async Task GetDeliveredOrdersAsyncShouldReturnAllDeliveredOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
               new Order { OrderStatus = OrderStatus.Delivered },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Delivered },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var deliveredOrders = await ordersService.GetDeliveredOrdersAsync();

            Assert.Equal(2, deliveredOrders.Count());
        }

        [Fact]
        public async Task GetDeniedOrdersAsyncShouldReturnAllDeniedOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Pending },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Denied },
               new Order { OrderStatus = OrderStatus.Denied },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Delivered },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var deniedOrders = await ordersService.GetDeniedOrdersAsync();

            Assert.Equal(2, deniedOrders.Count());
        }

        [Fact]
        public async Task GetPendingOrdersAsyncShouldReturnNothingIfNoPendingOrders()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var orders = new List<Order>
            {
               new Order { OrderStatus = OrderStatus.Open },
               new Order { OrderStatus = OrderStatus.Denied },
               new Order { OrderStatus = OrderStatus.Approved },
               new Order { OrderStatus = OrderStatus.Delivered },
               new Order { OrderStatus = OrderStatus.Shipped },
               new Order { OrderStatus = OrderStatus.Waiting },
            };
            dbContext.Orders.AddRange(orders);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var pendingOrders = await ordersService.GetPendingOrdersAsync();

            Assert.Empty(pendingOrders);
        }

        [Fact]
        public async Task GetOrderByIdAsyncShouldReturnOrderWhichIsNotOpen()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Pending };

            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var searchedOrder = await ordersService.GetOrderByIdAsync(order.Id);

            Assert.Equal(order.Id, searchedOrder.Id);
        }

        [Fact]
        public async Task GetOrderByIdAsyncShouldNotReturnOrderWhichIsOpen()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };

            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var searchedOrder = await ordersService.GetOrderByIdAsync(order.Id);

            Assert.Null(searchedOrder);
        }

        [Fact]
        public async Task OrderProductsByOrderIdAsyncShouldReturnAllOrderProductsInTheOrder()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open };
            dbContext.Orders.Add(order);

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

            var orderProducts = new List<OrderProduct>
            {
                new OrderProduct { Product = products.First(), Quantity = 1 },
                new OrderProduct { Product = products.Last(), Quantity = 2 },
            };

            order.Products = orderProducts;
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            var orderedProducts = await ordersService.OrderProductsByOrderIdAsync(order.Id);

            Assert.Equal(2, orderedProducts.Count());
        }

        [Theory]
        [InlineData(OrderStatus.Pending, OrderStatus.Denied)]
        [InlineData(OrderStatus.Open, OrderStatus.Open)]
        [InlineData(OrderStatus.Approved, OrderStatus.Approved)]
        [InlineData(OrderStatus.Shipped, OrderStatus.Shipped)]
        public async Task DeleteOrderAsyncShouldChangeOrderStatusFromPendingToDenied(OrderStatus orderStatus, OrderStatus expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                  .UseInMemoryDatabase(Guid.NewGuid().ToString())
                  .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = orderStatus };

            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.DeleteOrderAsync(order.Id);

            Assert.Equal(expected, order.OrderStatus);
        }

        [Theory]
        [InlineData(OrderStatus.Pending, PaymentStatus.Ondelivery, OrderStatus.Pending, PaymentStatus.Ondelivery)]
        [InlineData(OrderStatus.Shipped, PaymentStatus.Ondelivery, OrderStatus.Delivered, PaymentStatus.Paid)]
        [InlineData(OrderStatus.Shipped, PaymentStatus.Credit, OrderStatus.Delivered, PaymentStatus.Credit)]
        public async Task DeliverAsyncShoulChangeOrderStatusFromShippedToDeliveredAndPaymentStatusOnDeliveryToPaid(OrderStatus orderStatus, PaymentStatus paymentStatus, OrderStatus expectedOrder, PaymentStatus expectedPaymen)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = orderStatus, PaymentStatus = paymentStatus };

            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.DeliverAsync(order.Id);

            Assert.Equal(expectedOrder, order.OrderStatus);
            Assert.Equal(expectedPaymen, order.PaymentStatus);
        }

        [Theory]
        [InlineData(OrderStatus.Pending, OrderStatus.Pending)]
        [InlineData(OrderStatus.Approved, OrderStatus.Shipped)]
        [InlineData(OrderStatus.Open, OrderStatus.Open)]
        public async Task ShipAsyncShoulChangeOrderStatusFromApprovedToShipped(OrderStatus orderStatus, OrderStatus expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = orderStatus };

            dbContext.Orders.Add(order);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.ShipAsync(order.Id);

            Assert.Equal(expected, order.OrderStatus);
        }

        [Theory]
        [InlineData(OrderStatus.Pending, 3, 0, OrderStatus.Approved, 1, 0)]
        [InlineData(OrderStatus.Pending, 1, 0, OrderStatus.Waiting, 1, 2)]
        [InlineData(OrderStatus.Waiting, 2, 2, OrderStatus.Approved, 0, 0)]
        [InlineData(OrderStatus.WaitingCreditConfirmation, 1, 0, OrderStatus.Waiting, 1, 2)]
        [InlineData(OrderStatus.WaitingCreditConfirmation, 2, 0, OrderStatus.Approved, 0, 0)]
        [InlineData(OrderStatus.Shipped, 2, 0, OrderStatus.Shipped, 2, 0)]
        public async Task ApproveAsyncShouldchangeOrderStatusToApprovedAndReduceProductQuantityIfEnoughQuantity(OrderStatus orderStatus, int productQuantity, int inpendingOrders, OrderStatus expectedStatus, int expectedQuantity, int expectedInPedningOrders)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = orderStatus };
            dbContext.Orders.Add(order);

            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Price = 1199, Quantity = productQuantity, InPendingOrders = inpendingOrders };
            dbContext.Products.Add(product);
            await dbContext.SaveChangesAsync();

            var productService = new Mock<IProductsService>();
            productService.Setup(p => p.GetProductByIdAsync(product.Id))
                          .ReturnsAsync(product);

            var orderProduct = new OrderProduct { Product = product, Quantity = 2 };
            order.Products.Add(orderProduct);
            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.ApproveAsync(order.Id);

            Assert.Equal(expectedStatus, order.OrderStatus);
            Assert.Equal(expectedQuantity, product.Quantity);
            Assert.Equal(expectedInPedningOrders, product.InPendingOrders);
        }

        [Theory]
        [InlineData(PaymentType.Card, 1200, PaymentStatus.Paid, 0, OrderStatus.Pending)]
        [InlineData(PaymentType.Credit, 1200, PaymentStatus.Credit, 0, OrderStatus.WaitingCreditConfirmation)]
        [InlineData(PaymentType.CashОnDelivery, 99, PaymentStatus.Ondelivery, 5, OrderStatus.Pending)]
        public async Task FinishOrderAsyncShouldChangeStatusToFinishAndCalculateTheTotalAmount(PaymentType paymentType, decimal price, PaymentStatus expectedPayment, decimal expectedShipping, OrderStatus expectedOrderStatus)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                 .UseInMemoryDatabase(Guid.NewGuid().ToString())
                 .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var order = new Order { OrderStatus = OrderStatus.Open, PaymentType = paymentType };
            dbContext.Orders.Add(order);

            var productService = new Mock<IProductsService>();
            var invoicesService = new Mock<IInvoicesService>();
            var userService = new Mock<IUsersService>();

            var product = new Product { Name = "Canon M50", Price = price };
            dbContext.Products.Add(product);

            var orderProduct = new OrderProduct { Product = product };

            order.TotalPrice = orderProduct.Product.Price;

            await dbContext.SaveChangesAsync();

            var ordersService = new OrdersService(dbContext, userService.Object, productService.Object, invoicesService.Object);

            await ordersService.FinishOrderAsync(order);

            Assert.Equal(expectedShipping, order.Shipping);
            Assert.Equal(expectedPayment, order.PaymentStatus);
            Assert.Equal(expectedOrderStatus, order.OrderStatus);
        }
    }
}
