namespace Photoparallel.Services.Contracts
{
    using System;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IRentsService
    {
        Task SetRentDetailsAsync(Rent rent);

        Task<Rent> GetOpenRentByUserIdAsync(string username);

        Task<bool> AddProductAsync(int id, Rent rent);

        Task<bool> DeleteProductAsync(int productId, Rent rent);

        Task FinishRentAsync(Rent rent);
    }
}
