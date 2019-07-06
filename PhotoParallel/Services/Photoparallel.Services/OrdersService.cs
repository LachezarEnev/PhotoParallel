namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class OrdersService : IOrdersService
    {
        private readonly PhotoparallelDbContext context;
        private readonly IMapper mapper;

        public OrdersService(PhotoparallelDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            var allOrders = await this.context.Orders
                .Where(x => x.OrderStatus != OrderStatus.Open)
                .OrderBy(x => x.Id)
                .ToArrayAsync();

            return allOrders;
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
                .OrderBy(x => x.Id)
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
    }
}
