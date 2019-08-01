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

    public class InvoicesServiceTests
    {
        [Fact]
        public async Task CreateAsyncShouldCreateInvoice()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            var order = new Order()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 2500,
            };

            await invoicesService.CreateAsync(order);

            var invoices = await dbContext.Invoices.ToListAsync();

            Assert.Single(invoices);
        }

        [Fact]
        public async Task CreateRentInvoiceAsyncShouldCreateInvoice()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            var rent = new Rent()
            {
                Recipient = "Gosho Goshev",
                TotalPrice = 350,
            };

            await invoicesService.CreateRentInvoiceAsync(rent);

            var invoices = await dbContext.Invoices.ToListAsync();

            Assert.Single(invoices);
        }

        [Fact]
        public async Task CreateAsyncNullOrderShouldNotCreateInvoice()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            Order order = null;

            await invoicesService.CreateAsync(order);

            var invoices = await dbContext.Invoices.ToListAsync();

            Assert.Empty(invoices);
        }

        [Fact]
        public async Task CreateRentInvoiceAsyncNullRentShouldNotCreateInvoice()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            Rent rent = null;

            await invoicesService.CreateRentInvoiceAsync(rent);

            var invoices = await dbContext.Invoices.ToListAsync();

            Assert.Empty(invoices);
        }

        [Fact]
        public async Task GetAllAsyncShouldReturnAllInvoices()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            dbContext.Invoices.AddRange(new List<Invoice>
            {
                new Invoice { InvoiceNumber = "9630000001" },
                new Invoice { InvoiceNumber = "9630000002" },
                new Invoice { InvoiceNumber = "9630000003" },
                new Invoice { InvoiceNumber = "9630000004" },
                new Invoice { InvoiceNumber = "9630000005" },
            });

            await dbContext.SaveChangesAsync();

            var invoices = await invoicesService.GetAllAsync();

            Assert.Equal(5, invoices.Count());
        }

        [Fact]
        public async Task GetInvoiceByIdAsyncShouldReturnInvoice()
        {
            var options = new DbContextOptionsBuilder<PhotoparallelDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;
            var dbContext = new PhotoparallelDbContext(options);

            var invoicesService = new InvoicesService(dbContext);

            var invoiceNumber = "9630000001";

            dbContext.Invoices.AddRange(new List<Invoice>
            {
                new Invoice { InvoiceNumber = invoiceNumber },
                new Invoice { InvoiceNumber = "9630000002" },
                new Invoice { InvoiceNumber = "9630000003" },
                new Invoice { InvoiceNumber = "9630000004" },
                new Invoice { InvoiceNumber = "9630000005" },
            });

            await dbContext.SaveChangesAsync();

            var invoiceId = dbContext.Invoices.FirstOrDefault(x => x.InvoiceNumber == invoiceNumber).Id;

            var invoice = await invoicesService.GetInvoiceByIdAsync(invoiceId);

            Assert.Equal(invoiceNumber, invoice.InvoiceNumber);
        }
    }
}
