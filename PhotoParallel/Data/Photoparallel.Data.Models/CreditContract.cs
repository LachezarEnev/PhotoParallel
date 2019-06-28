namespace Photoparallel.Data.Models
{
    using System;

    public class CreditContract
    {
        public string Id { get; set; }

        public DateTime IssuedOn { get; set; } = DateTime.UtcNow;

        public DateTime ActiveUntil { get; set; }

        public decimal PricePerMonth { get; set; }

        public string CreditCompanyId { get; set; }

        public CreditCompany CreditCompany { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }
    }
}
