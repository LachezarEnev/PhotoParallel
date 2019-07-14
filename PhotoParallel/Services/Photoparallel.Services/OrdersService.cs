namespace Photoparallel.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Common;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class OrdersService : IOrdersService
    {
        private readonly PhotoparallelDbContext context;
        private readonly IUsersService usersService;
        private readonly IProductsService productsService;

        public OrdersService(PhotoparallelDbContext context, IUsersService usersService, IProductsService productsService)
        {
            this.context = context;
            this.usersService = usersService;
            this.productsService = productsService;
        }

        public async Task<bool> AddProductAsync(int id, Order order)
        {
            var product = await this.context.Products
                .Include(x => x.Images)
                .SingleOrDefaultAsync(x => x.Id == id);

            if (product == null || order == null)
            {
                return false;
            }

            if (order.Products.Any(x => x.ProductId == id))
            {
                var orderProduct = await this.context.OrderProducts.FirstOrDefaultAsync(x => x.ProductId == id && x.OrderId == order.Id);
                orderProduct.Quantity += 1;

                this.context.Update(orderProduct);
                await this.context.SaveChangesAsync();
            }
            else
            {
                var orderProduct = new OrderProduct
                {
                    Product = product,
                    Order = order,
                    Quantity = 1,
                };

                await this.context.AddAsync(orderProduct);
                await this.context.SaveChangesAsync();
            }

            order.TotalPrice = order.Products.Sum(x => x.Product.Price * x.Quantity);

            this.context.Update(order);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            var allOrders = await this.context.Orders
                .Where(x => x.OrderStatus != OrderStatus.Open)
                .OrderBy(x => x.Id)
                .ToArrayAsync();

            return allOrders;
        }

        public async Task<Order> GetOpenOrderByUserIdAsync(string username)
        {
            var user = this.usersService.GetUserByUsername(username);

            if (user == null)
            {
                return null;
            }

            var openOrder = await this.context.Orders
                .Include(x => x.Products)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Images)
                .SingleOrDefaultAsync(x => x.OrderStatus == OrderStatus.Open && x.Customer.UserName == user.UserName);

            if (openOrder == null)
            {
                openOrder = new Order
                {
                    Customer = user,
                };

                await this.context.Orders.AddAsync(openOrder);
                await this.context.SaveChangesAsync();
            }

            return openOrder;
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            var order = await this.context.Orders
                .Include(x => x.Customer)
                .FirstOrDefaultAsync(x => x.Id == orderId);

            return order;
        }

        public async Task<IEnumerable<Order>> GetPendingOrdersAsync()
        {
            var pendingOrders = await this.context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Pending)
                .OrderBy(x => x.CreatedOn)
                .ToArrayAsync();

            return pendingOrders;
        }

        public async Task<IEnumerable<OrderProduct>> OrderProductsByOrderIdAsync(int id)
        {
            var orderProducts = await this.context.OrderProducts
                .Include(x => x.Product)
                .ThenInclude(x => x.Images)
                .Where(x => x.OrderId == id)
                .ToArrayAsync();

            return orderProducts;
        }

        public async Task<bool> DeleteProductAsync(int productId, Order order)
        {
            var openOrder = await this.context.OrderProducts.FirstOrDefaultAsync(x => x.ProductId == productId && x.OrderId == order.Id);

            if (openOrder == null)
            {
                return false;
            }

            this.context.Remove(openOrder);
            await this.context.SaveChangesAsync();

            order.TotalPrice = order.Products.Sum(x => x.Product.Price * x.Quantity);

            this.context.Update(order);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EditProductQuantityAsync(int id, int quantity, Order order)
        {
            var orderProduct = await this.context.OrderProducts.FirstOrDefaultAsync(x => x.ProductId == id && x.OrderId == order.Id);

            if (orderProduct == null || quantity < 0)
            {
                return false;
            }

            if (quantity == 0)
            {
                this.context.Remove(orderProduct);
                await this.context.SaveChangesAsync();
            }
            else
            {
                orderProduct.Quantity = quantity;
                this.context.Update(orderProduct);
            }

            order.TotalPrice = order.Products.Sum(x => x.Product.Price * x.Quantity);

            this.context.Update(order);
            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<Order> AddShippingCostsToOrderAsync(int id)
        {
            var order = await this.GetOrderByIdAsync(id);

            if (order == null)
            {
                return null;
            }

            if (order.TotalPrice < 100)
            {
                order.TotalPrice += GlobalConstants.ShippingCosts;

                this.context.Update(order);
                await this.context.SaveChangesAsync();
            }

            return order;
        }

        public async Task SetOrderDetailsAsync(Order order, string shippingAddress, string firstName, string lastName, string phoneNumber, PaymentType paymentType)
        {
            order.Recipient = firstName + " " + lastName;
            order.RecipientPhoneNumber = phoneNumber;
            order.ShippingAddress = shippingAddress;
            order.PaymentType = paymentType;

            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }


        public async Task FinishOrderAsync(int orderId)
        {
            var order = await this.GetOrderByIdAsync(orderId);

            order.OrderStatus = OrderStatus.Pending;
            order.CreatedOn = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);

            if (order.TotalPrice < 100)
            {
                order.TotalPrice += GlobalConstants.ShippingCosts;
            }

            if (order.PaymentType == PaymentType.CashОnDelivery)
            {
                order.PaymentStatus = PaymentStatus.Ondelivery;
            }
            else
            {
                order.PaymentStatus = PaymentStatus.Paid;
            }

            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }
    }
}
