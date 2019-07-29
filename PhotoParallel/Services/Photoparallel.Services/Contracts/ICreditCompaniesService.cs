namespace Photoparallel.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Photoparallel.Data.Models;

    public interface ICreditCompaniesService
    {
        Task AddCompanyAsync(CreditCompany company);

        Task<IEnumerable<CreditCompany>> GetAllCompaniesAsync();

        Task<CreditCompany> GetCompanyByIdAsync(string id);

        Task EditCompanyAsync(CreditCompany comapany);

        Task HideCompanyAsync(CreditCompany company);

        Task ShowCompanyAsync(CreditCompany company);
    }
}
