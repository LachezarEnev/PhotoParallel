namespace Photoparallel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Xunit;

    public class CreditCompaniesServiceTests
    {
        [Fact]
        public async Task AddCompanyAsyncShouldAddCompany()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            var company = new CreditCompany { Name = "TBI" };
            await creditCompaniesService.AddCompanyAsync(company);

            var products = dbContext.CreditCompanies.ToList();

            Assert.Single(products);
            Assert.Equal(company.Name, products.First().Name);
        }

        [Fact]
        public async Task AddCompanyAsyncNullEntityShouldNotAddCompany()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                      .UseInMemoryDatabase(Guid.NewGuid().ToString())
                      .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            CreditCompany company = null;
            await creditCompaniesService.AddCompanyAsync(company);

            var companies = dbContext.CreditCompanies.ToList();

            Assert.Empty(companies);
        }

        [Fact]
        public async Task GetAllCompaniesAsyncShouldReturnAllCompanies()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                      .UseInMemoryDatabase(Guid.NewGuid().ToString())
                      .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            dbContext.CreditCompanies.AddRange(new List<CreditCompany>
            {
                new CreditCompany { Name = "TBI" },
                new CreditCompany { Name = "UniCredit" },
                new CreditCompany { Name = "ProCredit" },
            });
            await dbContext.SaveChangesAsync();

            var companies = await creditCompaniesService.GetAllCompaniesAsync();

            Assert.Equal(3, companies.Count());
        }

        [Fact]
        public async Task GetVisibleCompaniesAsyncShouldReturnVisibleCompanies()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                      .UseInMemoryDatabase(Guid.NewGuid().ToString())
                      .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            dbContext.CreditCompanies.AddRange(new List<CreditCompany>
            {
                new CreditCompany { Name = "TBI", Hide = true},
                new CreditCompany { Name = "UniCredit" },
                new CreditCompany { Name = "ProCredit" },
            });
            await dbContext.SaveChangesAsync();

            var companies = await creditCompaniesService.GetVisibleCompaniesAsync();

            Assert.Equal(2, companies.Count());
        }

        [Fact]
        public async Task GetCompanyByIdAsyncShouldReturnCompany()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                         .UseInMemoryDatabase(Guid.NewGuid().ToString())
                         .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            var companyName = "TBI";

            dbContext.CreditCompanies.AddRange(new List<CreditCompany>
            {
                new CreditCompany { Name = companyName },
                new CreditCompany { Name = "UniCredit" },
                new CreditCompany { Name = "ProCredit" },
            });
            await dbContext.SaveChangesAsync();

            var companyId = dbContext.CreditCompanies.FirstOrDefault(x => x.Name == companyName).Id;

            var company = await creditCompaniesService.GetCompanyByIdAsync(companyId);

            Assert.Equal(companyName, company.Name);
        }

        [Fact]
        public async Task EditCompanyAsyncShouldEditCompany()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                            .UseInMemoryDatabase(Guid.NewGuid().ToString())
                            .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            var company = new CreditCompany()
            {
                Name = "TBI",
                Interest = 12,
                Address = "Sofia, Mladost 4",
            };

            dbContext.CreditCompanies.Add(company);
            await dbContext.SaveChangesAsync();

            company.Name = "TBICredit";
            company.Interest = 10.5m;
            company.Address = "Sofia, Mladost 1A";

            await creditCompaniesService.EditCompanyAsync(company);

            var editedCompany = await dbContext.CreditCompanies.FirstOrDefaultAsync(x => x.Name == company.Name);

            Assert.Equal(company.Name, editedCompany.Name);
            Assert.Equal(company.Interest, editedCompany.Interest);
            Assert.Equal(company.Address, editedCompany.Address);
        }

        [Fact]
        public async Task HideCompanyAsyncShouldChangeHiteToTrue()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                               .UseInMemoryDatabase(Guid.NewGuid().ToString())
                               .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            var companyName = "TBI";
            dbContext.CreditCompanies.AddRange(new List<CreditCompany>
            {
                new CreditCompany { Name = companyName },
                new CreditCompany { Name = "UniCredit" },
                new CreditCompany { Name = "ProCredit" },
            });
            await dbContext.SaveChangesAsync();

            var company = dbContext.CreditCompanies.FirstOrDefault(x => x.Name == companyName);

            await creditCompaniesService.HideCompanyAsync(company);

            Assert.True(company.Hide);
        }

        [Fact]
        public async Task ShowCompanyAsyncShouldChangeHiteToTrue()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                               .UseInMemoryDatabase(Guid.NewGuid().ToString())
                               .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCompaniesService = new CreditCompaniesService(dbContext);

            var companyName = "TBI";
            dbContext.CreditCompanies.AddRange(new List<CreditCompany>
            {
                new CreditCompany { Name = companyName, Hide = true },
                new CreditCompany { Name = "UniCredit" },
                new CreditCompany { Name = "ProCredit" },
            });
            await dbContext.SaveChangesAsync();

            var company = dbContext.CreditCompanies.FirstOrDefault(x => x.Name == companyName);

            await creditCompaniesService.ShowCompanyAsync(company);

            Assert.False(company.Hide);
        }
    }
}
