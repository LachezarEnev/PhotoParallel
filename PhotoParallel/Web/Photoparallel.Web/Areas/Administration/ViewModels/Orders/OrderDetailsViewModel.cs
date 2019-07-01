namespace Photoparallel.Web.Areas.Administration.ViewModels.Orders
{
    using System;
    using System.Collections.Generic;

    public class OrderDetailsViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string ShippingAddress { get; set; }

        public string OrderStatus { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public int? InvoiceId { get; set; }

        public decimal TotalPrice { get; set; }

        public IList<OrderProductsViewModel> OrderProductsViewModel { get; set; }
    }
}
