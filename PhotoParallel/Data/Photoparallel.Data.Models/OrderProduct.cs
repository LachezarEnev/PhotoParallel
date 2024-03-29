﻿namespace Photoparallel.Data.Models
{
    public class OrderProduct
    {
        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public decimal TotalPrice => this.Quantity * this.Product.Price;
    }
}
