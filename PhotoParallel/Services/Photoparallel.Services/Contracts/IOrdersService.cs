namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;

    using Photoparallel.Data.Models;

    public interface IOrdersService
    {
        IEnumerable<Order> GetAllOrders();

        IEnumerable<Order> GetPendingOrders();
    }
}
