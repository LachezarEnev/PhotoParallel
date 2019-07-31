namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface ICreditsService
    {
        Task SetCreditDetailsAsync(CreditContract creditContract, Order order, string address, CreditCompany creditCompany, decimal salary, int months, string ucn, string idNumber);

        Task<CreditContract> GetOpenCreditsByUserIdAsync(string customerId);

        Task FinishCreditAsync(CreditContract credit);

        Task<IEnumerable<CreditContract>> GetAllCreditsByUserAsync(string username);

        Task<CreditContract> GetCreditByIdAsync(int id);

        Task<IEnumerable<CreditContract>> GetPendingCreditsAsync();

        Task<IEnumerable<CreditContract>> GetApprovedCreditsAsync();

        Task<IEnumerable<CreditContract>> GetDeniedCreditsAsync();

        Task ApproveAsync(int id);

        Task DeleteCreditAsync(int id);
    }
}
