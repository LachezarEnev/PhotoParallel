namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rent
    {
        public Rent()
        {
            this.Products = new HashSet<RentProduct>();
        }

        public string Id { get; set; }

        public string RenterId { get; set; }

        public ApplicationUser Renter { get; set; }

        public DateTime RentedOn { get; set; } = DateTime.UtcNow;

        public DateTime? ReturnedOn { get; set; }

        public decimal TotalPrice { get; set; }

        public string ShippingAddress { get; set; }

        public string ReceiptId { get; set; }

        public Receipt Receipt { get; set; }

        public ICollection<RentProduct> Products { get; set; }

        public decimal Guarantee => this.Products.Sum(x => (x.Product.Price * x.Quantity) * 0.50m);
    }
}
