namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

        public OrderStatus OrderStatus { get; set; } = OrderStatus.Open;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime? EstimatedDeliveryDate { get; set; }

        public string ShippingAddress { get; set; }

        public string CreditCardId { get; set; }

        public CreditCard CreditCard { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public CreditContract CreditContract { get; set; }

        public ICollection<OrderProduct> Products { get; set; }

        public decimal TotalPrice => this.Products.Sum(x => x.Product.Price * x.Quantity);
    }
}
