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

        Task<Order> GetOpenOrderByUserIdAsync(string username);

        Task<IEnumerable<OrderProduct>> OrderProductsByOrderIdAsync(int id);

        Task<bool> AddProductAsync(int id, Order order);

        Task<OrderProduct> GetOrderProductAsync(int id, Order order);

        Task<bool> DeleteProductAsync(int productId, Order order);

        Task<bool> EditProductQuantityAsync(int id, int quantity, Order order);
    }
}
