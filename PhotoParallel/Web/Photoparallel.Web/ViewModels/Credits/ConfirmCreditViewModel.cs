namespace Photoparallel.Web.ViewModels.Credits
{
    using System;

    using Photoparallel.Data.Models;

    public class ConfirmCreditViewModel
    {
        public CreditCompany CreditCompany { get; set; }

        public Order Order { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Ucn { get; set; }

        public string IdNumber { get; set; }

        public decimal Salary { get; set; }

        public DateTime ActiveUntil { get; set; }

        public decimal PricePerMonth { get; set; }

        public decimal TotalAmount { get; set; }

        public int Months { get; set; }
    }
}
