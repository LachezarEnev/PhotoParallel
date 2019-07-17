namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;

    public interface IOrdersService
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();

        Task<IEnumerable<Order>> GetAllOrdersByUserAsync(string username);

        Task<IEnumerable<Order>> GetPendingOrdersAsync();

        Task<IEnumerable<Order>> GetWaitingOrdersAsync();

        Task<IEnumerable<Order>> GetApprovedOrdersAsync();

        Task<IEnumerable<Order>> GetShippedOrdersAsync();

        Task<IEnumerable<Order>> GetDeliveredOrdersAsync();

        Task<IEnumerable<Order>> GetDeniedOrdersAsync();

        Task<Order> GetOrderByIdAsync(int orderId);

        Task<Order> GetOpenOrderByUserIdAsync(string username);

        Task<IEnumerable<OrderProduct>> OrderProductsByOrderIdAsync(int id);

        Task<bool> AddProductAsync(int id, Order order);

        Task<bool> DeleteProductAsync(int productId, Order order);

        Task<bool> EditProductQuantityAsync(int id, int quantity, Order order);

        Task<Order> AddShippingCostsToOrderAsync(int orderId);

        Task SetOrderDetailsAsync(Order order, string shippingAddress, string firstName, string lastName, string phoneNumber, PaymentType paymentType);

        Task FinishOrderAsync(Order order);

        Task ApproveAsync(int id);

        Task ShipAsync(int id);

        Task DeliverAsync(int id);

        Task DeleteOrderAsync(int id);
    }
}
