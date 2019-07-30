namespace Photoparallel.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;

    public class CreditCompaniesService : ICreditCompaniesService
    {
        private readonly PhotoparallelDbContext context;

        public CreditCompaniesService(PhotoparallelDbContext context)
        {
            this.context = context;
        }

        public async Task AddCompanyAsync(CreditCompany company)
        {
            if (company == null)
            {
                return;
            }

            this.context.CreditCompanies.Add(company);
            await this.context.SaveChangesAsync();
        }

        public async Task EditCompanyAsync(CreditCompany comapany)
        {
            bool companyExists = await this.context.CreditCompanies.AnyAsync(x => x.Id == comapany.Id);

            if (!companyExists)
            {
                return;
            }

            this.context.Update(comapany);
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CreditCompany>> GetAllCompaniesAsync()
        {
            var companies = await this.context.CreditCompanies.ToArrayAsync();

            return companies;
        }

        public async Task<CreditCompany> GetCompanyByIdAsync(string id)
        {
            var company = await this.context.CreditCompanies
                .SingleOrDefaultAsync(x => x.Id == id);

            return company;
        }

        public async Task<IEnumerable<CreditCompany>> GetVisibleCompaniesAsync()
        {
            var companies = await this.context.CreditCompanies
                .Where(x => x.Hide == false)
                .ToArrayAsync();

            return companies;
        }

        public async Task HideCompanyAsync(CreditCompany company)
        {
            company.Hide = true;

            this.context.Update(company);
            await this.context.SaveChangesAsync();
        }

        public async Task ShowCompanyAsync(CreditCompany company)
        {
            company.Hide = false;

            this.context.Update(company);
            await this.context.SaveChangesAsync();
        }
    }
}
