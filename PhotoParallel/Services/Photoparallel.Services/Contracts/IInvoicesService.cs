namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IInvoicesService
    {
        Task CreateAsync(Order order);

        Task CreateRentInvoiceAsync(Rent rent);

        Task<Invoice> GetInvoiceByIdAsync(int id);

        Task<IEnumerable<Invoice>> GetAllAsync();
    }
}
