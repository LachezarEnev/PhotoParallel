namespace Photoparallel.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Photoparallel.Common;
    using Photoparallel.Data;
    using Photoparallel.Data.Models;
    using Photoparallel.Services.Contracts;

    public class InvoicesService : IInvoicesService
    {
        private readonly PhotoparallelDbContext context;

        public InvoicesService(PhotoparallelDbContext context)
        {
            this.context = context;
        }

        public async Task CreateAsync(Order order)
        {
            //var order = await this.context.Orders
            //   .Include(x => x.Customer)
            //   .FirstOrDefaultAsync(x => x.Id == orderId);

            if (order == null)
            {
                return;
            }

            var invoice = new Invoice()
            {
                CustomerId = order.CustomerId,
                IssuedOn = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow),
                TotalAmount = order.GrandTotal,
                ShippingAddress = order.ShippingAddress,
            };

            this.context.Add(invoice);
            await this.context.SaveChangesAsync();

            invoice.InvoiceNumber = "963" + invoice.Id.ToString("D7");

            this.context.Update(invoice);
            order.Invoice = invoice;
            await this.context.SaveChangesAsync();
        }

        public async Task CreateRentInvoiceAsync(Rent rent)
        {
            //var rent = await this.rentsService.GetRentByIdAsync(rentId);
            //var rent = await this.context.Rents
            //    .Include(x => x.Customer)
            //    .FirstOrDefaultAsync(x => x.Id == rentId);

            if (rent == null)
            {
                return;
            }

            var invoice = new Invoice()
            {
                CustomerId = rent.CustomerId,
                IssuedOn = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow),
                TotalAmount = rent.TotalPrice + rent.Penalty,
                ShippingAddress = rent.ShippingAddress,
            };

            this.context.Add(invoice);
            await this.context.SaveChangesAsync();

            invoice.InvoiceNumber = "963" + invoice.Id.ToString("D7");

            this.context.Update(invoice);
            rent.Invoice = invoice;
            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Invoice>> GetAllAsync()
        {
            var allInvoices = await this.context.Invoices
                .ToListAsync();

            return allInvoices;
        }

        public async Task<Invoice> GetInvoiceByIdAsync(int id)
        {
            var invoice = await this.context.Invoices
                .Include(x => x.Customer)
                .Include(x => x.Order)
                .Include(x => x.Rent)
                .SingleOrDefaultAsync(x => x.Id == id);

            return invoice;
        }
    }
}
