namespace Photoparallel.Web.Areas.Administration.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;

    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string OrderStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public string EstimatedDeliveryDate { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal Shipping { get; set; }

        public decimal GrandTotal { get; set; }

        public string Invoice { get; set; }

        public string PaymentType { get; set; }

        public string PaymentStatus { get; set; }

        public IList<OrderProductsViewModel> OrderProductsViewModel { get; set; }
    }
}
