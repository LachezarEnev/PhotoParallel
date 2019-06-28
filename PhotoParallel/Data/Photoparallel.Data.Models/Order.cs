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

        public string Id { get; set; }

        public string CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }

        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public string ShippingAddress { get; set; }

        public string ReceiptId { get; set; }

        public Receipt Receipt { get; set; }

        public CreditContract CreditContract { get; set; }

        public ICollection<OrderProduct> Products { get; set; }

        public decimal TotalPrice => this.Products.Sum(x => x.Product.Price * x.Quantity);
    }
}
