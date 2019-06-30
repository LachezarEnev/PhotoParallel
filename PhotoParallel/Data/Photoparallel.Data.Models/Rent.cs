namespace Photoparallel.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Photoparallel.Data.Models.Enums;

    public class Rent
    {
        public Rent()
        {
            this.Products = new HashSet<RentProduct>();
        }

        public int Id { get; set; }

        public string CustomerId { get; set; }

        public ApplicationUser Customer { get; set; }

        public DateTime RentedOn { get; set; } = DateTime.UtcNow;

        public DateTime? ReturnedOn { get; set; }

        public decimal TotalPrice { get; set; }

        public string ShippingAddress { get; set; }

        public string CreditCardId { get; set; }

        public CreditCard CreditCard { get; set; }

        public int? InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public ICollection<RentProduct> Products { get; set; }

        public decimal Guarantee => this.Products.Sum(x => (x.Product.Price * x.Quantity) * 0.50m);
    }
}
