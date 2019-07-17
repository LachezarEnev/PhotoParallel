namespace Photoparallel.Services.Contracts
{
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface IInvoicesService
    {
        Task CreateAsync(int orderId);

        Task<Invoice> GetInvoiceByIdAsync(int id);
    }
}
