namespace Photoparallel.Data.Models
{
    using System;

    using Photoparallel.Common;
    using Photoparallel.Data.Models.Enums;

    public class CreditContract
    {
        public int Id { get; set; }

        public DateTime IssuedOn { get; set; } = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);

        public DateTime ActiveUntil { get; set; }

        public decimal PricePerMonth { get; set; }

        public string Ucn { get; set; }

        public string IdNumber { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public CreditStatus CreditStatus { get; set; } = CreditStatus.Pending;

        public string CreditCompanyId { get; set; }

        public CreditCompany CreditCompany { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }
    }
}
