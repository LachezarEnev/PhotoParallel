namespace Photoparallel.Services
{
    using System;
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

        public async Task CreateAsync(int orderId)
        {
            var order = await this.context.Orders
                .Include(x => x.Customer)
                .SingleOrDefaultAsync(x => x.Id == orderId);

            if (order == null)
            {
                return;
            }

            var invoice = new Invoice()
            {
                Customer = order.Customer,
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
    }
}
