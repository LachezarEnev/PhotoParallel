namespace Photoparallel.Data.Models
{
    using System;

    public class Receipt
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public DateTime IssuedOn { get; set; } = DateTime.UtcNow;

        public decimal TotalAmount { get; set; }

        public string ShippingAddress { get; set; }

        public Order Order { get; set; }

        public Rent Rent { get; set; }
    }
}
