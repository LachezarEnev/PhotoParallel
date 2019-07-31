namespace Photoparallel.Web.Areas.Administration.ViewModels.Credits
{
    using System;

    using Photoparallel.Data.Models;
    using Photoparallel.Data.Models.Enums;

    public class DetailsCreditViewModel
    {
        public int Id { get; set; }

        public CreditCompany CreditCompany { get; set; }

        public Order Order { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Ucn { get; set; }

        public string IdNumber { get; set; }

        public decimal Salary { get; set; }

        public DateTime ActiveUntil { get; set; }

        public decimal PricePerMonth { get; set; }

        public decimal TotalAmount { get; set; }

        public int Months { get; set; }

        public CreditStatus CreditStatus { get; set; }
    }
}
