namespace Photoparallel.Web.ViewModels.Invoices
{
    using System;
    using System.Collections.Generic;

    public class InvoiceViewModel
    {
        public int Id { get; set; }

        public DateTime IssuedOn { get; set; }

        public string InvoiceNumber { get; set; }

        public string OrderNumber { get; set; }

        public string Recipient { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal NetPrice { get; set; }

        public decimal Vat { get; set; }

        public string ShippingAddress { get; set; }

        public IList<InvoiceOrderProductsViewModel> InvoiceProducts { get; set; }
    }
}
