namespace Photoparallel.Web.ViewModels.Invoices
{
    using System;
    using System.Collections.Generic;

    public class InvoiceRentViewModel
    {
        public int Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public string InvoiceNumber { get; set; }

        public string RentNumber { get; set; }

        public string Recipient { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal NetPrice { get; set; }

        public decimal Vat { get; set; }

        public decimal Penalty { get; set; }

        public int Days { get; set; }

        public string ShippingAddress { get; set; }

        public IList<InvoiceRentProductsViewModel> InvoiceProducts { get; set; }
    }
}