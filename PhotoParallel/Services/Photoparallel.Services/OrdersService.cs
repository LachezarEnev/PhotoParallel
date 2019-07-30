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
        private readonly IInvoicesService invoicesService;

        public OrdersService(PhotoparallelDbContext context, IUsersService usersService, IProductsService productsService, IInvoicesService invoicesService)
        {
            this.context = context;
            this.usersService = usersService;
            this.productsService = productsService;
            this.invoicesService = invoicesService;
        }

        public async Task<bool> AddProductAsync(int id, Order order)
        {
            var product = await this.productsService.GetProductByIdAsync(id);

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
                .OrderByDescending(x => x.CreatedOn)
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
                    OrderStatus = OrderStatus.Open,
                };

                await this.context.Orders.AddAsync(openOrder);
                await this.context.SaveChangesAsync();
            }
            else
            {
                var totalPrice = openOrder.Products.Sum(x => x.Product.Price * x.Quantity);

                if (openOrder.TotalPrice != totalPrice)
                {
                    openOrder.TotalPrice = totalPrice;
                    await this.context.SaveChangesAsync();
                }
            }

            return openOrder;
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            var order = await this.context.Orders
                .Include(x => x.Customer)
                .Include(x => x.Invoice)
                .Where(x => x.OrderStatus != OrderStatus.Open)
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

        public async Task<IEnumerable<Order>> GetWaitingOrdersAsync()
        {
            var waitingOrders = await this.context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Waiting)
                .OrderBy(x => x.EstimatedDeliveryDate)
                .ToArrayAsync();

            return waitingOrders;
        }

        public async Task<IEnumerable<Order>> GetApprovedOrdersAsync()
        {
            var approvedOrders = await this.context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Approved)
                .OrderBy(x => x.EstimatedDeliveryDate)
                .ToArrayAsync();

            return approvedOrders;
        }

        public async Task<IEnumerable<Order>> GetShippedOrdersAsync()
        {
            var shippedOrders = await this.context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Shipped)
                .OrderBy(x => x.EstimatedDeliveryDate)
                .ToArrayAsync();

            return shippedOrders;
        }

        public async Task<IEnumerable<Order>> GetDeliveredOrdersAsync()
        {
            var deliveredOrders = await this.context.Orders
               .Where(x => x.OrderStatus == OrderStatus.Delivered)
               .OrderByDescending(x => x.EstimatedDeliveryDate)
               .ToArrayAsync();

            return deliveredOrders;
        }

        public async Task<IEnumerable<Order>> GetDeniedOrdersAsync()
        {
            var deliveredOrders = await this.context.Orders
               .Where(x => x.OrderStatus == OrderStatus.Denied)
               .OrderByDescending(x => x.CreatedOn)
               .ToArrayAsync();

            return deliveredOrders;
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
            var orderProduct = await this.context.OrderProducts.FirstOrDefaultAsync(x => x.ProductId == productId && x.OrderId == order.Id);

            if (orderProduct == null)
            {
                return false;
            }

            this.context.Remove(orderProduct);
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

        public async Task FinishOrderAsync(Order order)
        {
            if (order.PaymentType == PaymentType.Credit)
            {
                order.OrderStatus = OrderStatus.WaitingCreditConfirmation;
            }
            else
            {
                order.OrderStatus = OrderStatus.Pending;
            }

            order.CreatedOn = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);

            if (order.TotalPrice < 100)
            {
                order.Shipping = GlobalConstants.ShippingCosts;
            }

            if (order.PaymentType == PaymentType.CashОnDelivery)
            {
                order.PaymentStatus = PaymentStatus.Ondelivery;
            }
            else if (order.PaymentType == PaymentType.Card)
            {
                order.PaymentStatus = PaymentStatus.Paid;
            }
            else
            {
                order.PaymentStatus = PaymentStatus.Credit;
            }

            var orderProducts = await this.context.OrderProducts
                .Where(x => x.OrderId == order.Id)
                .ToListAsync();

            foreach (var orderProduct in orderProducts)
            {
                orderProduct.ProductPrice = orderProduct.Product.Price;
                this.context.Update(orderProduct);
            }

            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Order>> GetAllOrdersByUserAsync(string username)
        {
            var orders = await this.context.Orders
                .Where(x => x.OrderStatus != OrderStatus.Open && x.Customer.UserName == username)
                .OrderByDescending(x => x.Id)
                .ToArrayAsync();

            return orders;
        }

        public async Task ApproveAsync(int id)
        {
            var order = await this.context.Orders
                .Include(x => x.Products)
                .SingleOrDefaultAsync(x => x.Id == id && (x.OrderStatus == OrderStatus.Pending || x.OrderStatus == OrderStatus.Waiting));

            if (order == null)
            {
                return;
            }

            bool isOutOfStock = await this.CheckIfItsOutOfStock(order);

            if (isOutOfStock)
            {
                if (order.OrderStatus == OrderStatus.Waiting)
                {
                    return;
                }

                order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(7);
                order.OrderStatus = OrderStatus.Waiting;
                this.context.Update(order);
                await this.context.SaveChangesAsync();

                return;
            }

            foreach (var orderProduct in order.Products)
            {
                var product = await this.productsService.GetProductByIdAsync(orderProduct.ProductId);

                product.InPendingOrders -= orderProduct.Quantity;
                product.Quantity -= orderProduct.Quantity;
            }

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(3);
            }
            else
            {
                order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(2);
            }

            order.OrderStatus = OrderStatus.Approved;

            this.context.Update(order);
            await this.context.SaveChangesAsync();

            await this.invoicesService.CreateAsync(order);
        }

        public async Task ShipAsync(int id)
        {
            var order = await this.context.Orders
                .SingleOrDefaultAsync(x => x.Id == id && x.OrderStatus == OrderStatus.Approved);

            if (order == null)
            {
                return;
            }

            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(2);
            }
            else
            {
                order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow).AddDays(1);
            }

            order.OrderStatus = OrderStatus.Shipped;

            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }

        public async Task DeliverAsync(int id)
        {
            var order = await this.context.Orders
                .SingleOrDefaultAsync(x => x.Id == id && x.OrderStatus == OrderStatus.Shipped);

            if (order == null)
            {
                return;
            }

            order.OrderStatus = OrderStatus.Delivered;
            order.EstimatedDeliveryDate = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);

            if (order.PaymentStatus == PaymentStatus.Ondelivery)
            {
                order.PaymentStatus = PaymentStatus.Paid;
            }

            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await this.context.Orders
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (order == null)
            {
                return;
            }

            order.OrderStatus = OrderStatus.Denied;
            this.context.Update(order);
            await this.context.SaveChangesAsync();
        }

        private async Task<bool> CheckIfItsOutOfStock(Order order)
        {
            bool isOutOfStock = false;

            foreach (var orderProduct in order.Products)
            {
                var product = await this.productsService.GetProductByIdAsync(orderProduct.ProductId);

                if (order.OrderStatus != OrderStatus.Waiting)
                {
                    product.InPendingOrders += orderProduct.Quantity;
                }

                if (product.Quantity - orderProduct.Quantity < 0)
                {
                    isOutOfStock = true;
                }
            }

            if (isOutOfStock)
            {
                return true;
            }

            return false;
        }
    }
}
