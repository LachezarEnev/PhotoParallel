namespace Photoparallel.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Xunit;

    public class CreditcardsServiceTests
    {
        [Fact]
        public async Task PayWithCardAsyncShouldAddCard()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCardsService = new CreditCardsService(dbContext);

            var order = new Order()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 1500,
            };

            var user = new ApplicationUser()
            {
                FirstName = "Gosho",
                LastName = "Goshev",
            };

            var card = new CreditCard()
            {
                Number = "1234567891234567",
                Customer = user,
            };

            await creditCardsService.PayWithCardAsync(card, user, order);

            var creditCards = await dbContext.CreditCards.ToListAsync();

            Assert.Single(creditCards);
        }

        [Fact]
        public async Task PayWithCardAsyncShouldNotAddExistingCart()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCardsService = new CreditCardsService(dbContext);

            var order = new Order()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 1500,
            };

            var user = new ApplicationUser()
            {
                UserName = "gosho@sth.bg",
                FirstName = "Gosho",
                LastName = "Goshev",
            };

            var card = new CreditCard()
            {
                Number = "1234567891234567",
                Customer = user,
            };

            dbContext.CreditCards.AddRange(new List<CreditCard>
            {
                new CreditCard { Number = "1234567891234567", Customer = user },
                new CreditCard { Number = "1111111111111111", Customer = user },
                new CreditCard { Number = "2222222222222222", Customer = user },
            });

            await dbContext.SaveChangesAsync();

            await creditCardsService.PayWithCardAsync(card, user, order);

            var creditCards = await dbContext.CreditCards.ToListAsync();

            Assert.Equal(3, creditCards.Count);
        }

        [Fact]
        public async Task PayRentWithCardAsyncShouldAddCard()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCardsService = new CreditCardsService(dbContext);

            var rent = new Rent()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 500,
            };

            var user = new ApplicationUser()
            {
                FirstName = "Gosho",
                LastName = "Goshev",
            };

            var card = new CreditCard()
            {
                Number = "1234567891234567",
                Customer = user,
            };

            await creditCardsService.PayRentWithCardAsync(card, user, rent);

            var creditCards = await dbContext.CreditCards.ToListAsync();

            Assert.Single(creditCards);
        }

        [Fact]
        public async Task PayRentWithCardAsyncShouldNotAddExistingCart()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var creditCardsService = new CreditCardsService(dbContext);

            var rent = new Rent()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 500,
            };

            var user = new ApplicationUser()
            {
                UserName = "gosho@sth.bg",
                FirstName = "Gosho",
                LastName = "Goshev",
            };

            var card = new CreditCard()
            {
                Number = "1234567891234567",
                Customer = user,
            };

            dbContext.CreditCards.AddRange(new List<CreditCard>
            {
                new CreditCard { Number = "1234567891234567", Customer = user },
                new CreditCard { Number = "1111111111111111", Customer = user },
                new CreditCard { Number = "2222222222222222", Customer = user },
            });

            await dbContext.SaveChangesAsync();

            await creditCardsService.PayRentWithCardAsync(card, user, rent);

            var creditCards = await dbContext.CreditCards.ToListAsync();

            Assert.Equal(3, creditCards.Count);
        }
    }
}
