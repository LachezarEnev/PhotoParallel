namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Photoparallel.Common;
    using Photoparallel.Data.Models.Enums;

    public class Order
    {
        public Order()
        {
            this.Products = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public string Recipient { get; set; }

        public string RecipientPhoneNumber { get; set; }

        public OrderStatus OrderStatus { get; set; } = OrderStatus.Open;

        public PaymentStatus PaymentStatus { get; set; }

        public PaymentType PaymentType { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow.AddHours(GlobalConstants.BulgarianHoursFromUtcNow);

        public DateTime? EstimatedDeliveryDate { get; set; }

        public string ShippingAddress { get; set; }

        public string CreditCardId { get; set; }

        public CreditCard CreditCard { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public CreditContract CreditContract { get; set; }

        public ICollection<OrderProduct> Products { get; set; }

        public decimal TotalPrice { get; set; } = 0;
    }
}
