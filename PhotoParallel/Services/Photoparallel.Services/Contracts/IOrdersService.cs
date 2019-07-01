namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();

        Task<IEnumerable<Order>> GetPendingOrdersAsync();

        Task<Order> GetOrderByIdAsync(int orderId);

        Task<IEnumerable<OrderProduct>> OrderProductsByOrderIdAsync(int id);
    }
}
