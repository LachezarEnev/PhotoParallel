namespace Photoparallel.Web.ViewModels.Credits
{
    using System;

    using Photoparallel.Data.Models;

    public class CreditDetailsViewModel
    {
        public int Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public DateTime ActiveUntil { get; set; }

        public decimal PricePerMonth { get; set; }

        public int Months { get; set; }

        public decimal TotalAmount { get; set; }

        public string Ucn { get; set; }

        public string IdNumber { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public CreditCompany CreditCompany { get; set; }

        public Order Order { get; set; }

        public ApplicationUser Customer { get; set; }
    }
}
