namespace Photoparallel.Data.Models
{
    using System;

    using Photoparallel.Common;

    public class Invoice
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public DateTime IssuedOn { get; set; }

        public string InvoiceNumber { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal NetPrice => this.TotalAmount / 1.20m;

        public decimal Vat => this.TotalAmount - this.NetPrice;

        public string ShippingAddress { get; set; }

        public Order Order { get; set; }

        public Rent Rent { get; set; }
    }
}
