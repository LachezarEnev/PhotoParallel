namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;

    public class OrdersService : IOrdersService
    {
        private readonly PhotoparallelDbContext context;

        public OrdersService(PhotoparallelDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var allOrders = this.context.Orders
                .Include(x => x.Customer);

            return allOrders;
        }

        public IEnumerable<Order> GetPendingOrders()
        {
            var pendingOrders = this.context.Orders
                .Include(x => x.Customer)
                .Where(x => x.OrderStatus == OrderStatus.Pending);

            return pendingOrders;
        }
    }
}
