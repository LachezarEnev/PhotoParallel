namespace Photoparallel.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IRentsService
    {
        Task SetRentDetailsAsync(Rent rent);

        Task<Rent> CreateOpenRentByUserIdAsync(string username);

        Task<Rent> GetOpenRentAsync(string username);

        Task<bool> AddProductAsync(int id, Rent rent);

        Task<bool> DeleteProductAsync(int productId, Rent rent);

        Task FinishRentAsync(Rent rent);

        Task<IEnumerable<Rent>> GetAllRentsByUserAsync(string username);

        Task<Rent> GetRentByIdAsync(int id);

        Task<IEnumerable<RentProduct>> RentProductsByRentIdAsync(int id);
    }
}
