namespace Photoparallel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;
    using Photoparallel.Services.Contracts;
    using Xunit;

    public class CreditsServiceTests
    {
        [Fact]
        public async Task GetOpenCreditByUserIdAsyncShouldReturnOpenCreditrByUser()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            dbContext.Add(user1);
            dbContext.Add(user2);

            var credits = new List<CreditContract>
            {
               new CreditContract { CreditStatus = CreditStatus.Open, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Pending, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Approved, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Open, Customer = user2 },
               new CreditContract { CreditStatus = CreditStatus.Denied, Customer = user1 },
            };
            dbContext.CreditContracts.AddRange(credits);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var userCredit = await creditsService.GetOpenCreditsByUserIdAsync(user1.Id);

            Assert.Equal(user1.UserName, userCredit.Customer.UserName);
            Assert.Equal(CreditStatus.Open, userCredit.CreditStatus);
        }

        [Fact]
        public async Task GetAllCreditsByUserAsyncShouldReturnAllCreditsrByUserWithoutOpenCredit()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var user1 = new ApplicationUser { UserName = "gosho@sth.bg" };
            var user2 = new ApplicationUser { UserName = "pesho@sth.bg" };

            dbContext.Add(user1);
            dbContext.Add(user2);

            var credits = new List<CreditContract>
            {
               new CreditContract { CreditStatus = CreditStatus.Open, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Pending, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Approved, Customer = user1 },
               new CreditContract { CreditStatus = CreditStatus.Pending, Customer = user2 },
               new CreditContract { CreditStatus = CreditStatus.Denied, Customer = user1 },
            };
            dbContext.CreditContracts.AddRange(credits);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var userCredits = await creditsService.GetAllCreditsByUserAsync(user1.UserName);

            Assert.Equal(3, userCredits.Count());
        }

        [Fact]
        public async Task GetCreditByIdAsyncShouldReturnCredit()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credit = new CreditContract { CreditStatus = CreditStatus.Pending, };

            dbContext.CreditContracts.Add(credit);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var searchedCredit = await creditsService.GetCreditByIdAsync(credit.Id);

            Assert.Equal(credit.Id, searchedCredit.Id);
        }

        [Fact]
        public async Task GetCreditByIdAsyncShouldNotReturnOpenCredit()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credit = new CreditContract { CreditStatus = CreditStatus.Open, };

            dbContext.CreditContracts.Add(credit);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var searchedCredit = await creditsService.GetCreditByIdAsync(credit.Id);

            Assert.Null(searchedCredit);
        }

        [Fact]
        public async Task GetPendingCreditsAsyncShouldReturnAllPendingCredits()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credits = new List<CreditContract>
            {
               new CreditContract { CreditStatus = CreditStatus.Open },
               new CreditContract { CreditStatus = CreditStatus.Pending },
               new CreditContract { CreditStatus = CreditStatus.Approved },
               new CreditContract { CreditStatus = CreditStatus.Pending },
               new CreditContract { CreditStatus = CreditStatus.Denied },
            };
            dbContext.CreditContracts.AddRange(credits);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var pendingCredits = await creditsService.GetPendingCreditsAsync();

            Assert.Equal(2, pendingCredits.Count());
        }

        [Fact]
        public async Task GetApprovedCreditsAsyncShouldReturnAllApprovedCredits()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credits = new List<CreditContract>
            {
               new CreditContract { CreditStatus = CreditStatus.Open },
               new CreditContract { CreditStatus = CreditStatus.Pending },
               new CreditContract { CreditStatus = CreditStatus.Approved },
               new CreditContract { CreditStatus = CreditStatus.Approved },
               new CreditContract { CreditStatus = CreditStatus.Denied },
            };
            dbContext.CreditContracts.AddRange(credits);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var approvedCredits = await creditsService.GetApprovedCreditsAsync();

            Assert.Equal(2, approvedCredits.Count());
        }

        [Fact]
        public async Task GetDeniedCreditsAsyncShouldReturnAllDeniedCredits()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credits = new List<CreditContract>
            {
               new CreditContract { CreditStatus = CreditStatus.Open },
               new CreditContract { CreditStatus = CreditStatus.Pending },
               new CreditContract { CreditStatus = CreditStatus.Denied },
               new CreditContract { CreditStatus = CreditStatus.Approved },
               new CreditContract { CreditStatus = CreditStatus.Denied },
            };
            dbContext.CreditContracts.AddRange(credits);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            var deniedCredits = await creditsService.GetDeniedCreditsAsync();

            Assert.Equal(2, deniedCredits.Count());
        }

        [Fact]
        public async Task FinishCreditAsyncShouldChangeCreditStatusToPending()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credit = new CreditContract { CreditStatus = CreditStatus.Open, Months = 12};

            dbContext.CreditContracts.Add(credit);
            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            await creditsService.FinishCreditAsync(credit);

            Assert.Equal(CreditStatus.Pending, credit.CreditStatus);
            Assert.Equal(DateTime.UtcNow.ToString("dd/MM/YYYY"), credit.IssuedOn.ToString("dd/MM/YYYY"));
            Assert.Equal(DateTime.UtcNow.AddMonths(credit.Months).ToString("dd/MM/YYYY"), credit.ActiveUntil.ToString("dd/MM/YYYY"));
        }

        [Theory]
        [InlineData(CreditStatus.Pending, CreditStatus.Approved)]
        [InlineData(CreditStatus.Open, CreditStatus.Open)]
        [InlineData(CreditStatus.Denied, CreditStatus.Denied)]
        public async Task ApproveAsyncShouldChangeCreditStatusToApproved(CreditStatus creditStatus, CreditStatus expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credit = new CreditContract { CreditStatus = creditStatus };

            dbContext.CreditContracts.Add(credit);

            var order = new Order { OrderStatus = OrderStatus.Pending };
            dbContext.Orders.Add(order);

            credit.Order = order;

            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            await creditsService.ApproveAsync(credit.Id);

            Assert.Equal(expected, credit.CreditStatus);
        }

        [Theory]
        [InlineData(CreditStatus.Pending, CreditStatus.Denied)]
        [InlineData(CreditStatus.Open, CreditStatus.Open)]
        [InlineData(CreditStatus.Approved, CreditStatus.Approved)]
        public async Task DeleteCreditAsyncShouldDeletePendingCredit(CreditStatus creditStatus, CreditStatus expected)
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                   .UseInMemoryDatabase(Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var credit = new CreditContract { CreditStatus = creditStatus };

            dbContext.CreditContracts.Add(credit);

            var order = new Order { OrderStatus = OrderStatus.Pending };
            dbContext.Orders.Add(order);

            credit.Order = order;

            await dbContext.SaveChangesAsync();

            var ordersService = new Mock<IOrdersService>();

            var creditsService = new CreditsService(dbContext, ordersService.Object);

            await creditsService.DeleteCreditAsync(credit.Id);

            Assert.Equal(expected, credit.CreditStatus);
        }
    }
}
