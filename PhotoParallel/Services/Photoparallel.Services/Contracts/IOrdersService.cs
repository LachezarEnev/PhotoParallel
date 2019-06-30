namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IOrdersService
    {
        IEnumerable<Order> GetAllOrders();

        IEnumerable<Order> GetPendingOrders();
    }
}
