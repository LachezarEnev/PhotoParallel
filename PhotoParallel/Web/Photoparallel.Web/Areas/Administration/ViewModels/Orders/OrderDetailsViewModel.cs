namespace Photoparallel.Web.Areas.Administration.ViewModels.Orders
{
    using Photoparallel.Data.Models;
    using System;
    using System.Collections.Generic;

    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string Email { get; set; }

        public string OrderStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public string EstimatedDeliveryDate { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Shipping { get; set; }

        public decimal GrandTotal { get; set; }

        public string Invoice { get; set; }

        public int InvoiceId { get; set; }

        public string PaymentType { get; set; }

        public string PaymentStatus { get; set; }

        public CreditContract CreditContract { get; set; }

        public IList<OrderProductsViewModel> OrderProductsViewModel { get; set; }
    }
}
