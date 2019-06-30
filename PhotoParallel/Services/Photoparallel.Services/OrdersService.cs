namespace Photoparallel.Services
{
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using System.Collections.Generic;
    using System.Linq;

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
                .OrderBy(x => x.Id);

            return allOrders;
        }

        public IEnumerable<Order> GetPendingOrders()
        {
            var pendingOrders = this.context.Orders
                .Where(x => x.OrderStatus == OrderStatus.Pending)
                .OrderBy(x => x.Id);

            return pendingOrders;
        }
    }
}
