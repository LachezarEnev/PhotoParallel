namespace Photoparallel.Data.Models
{
    using System.Collections.Generic;

    using Photoparallel.Data.Models.Enums;

    public class Product
    {
        public Product()
        {
            this.Orders = new HashSet<OrderProduct>();
            this.Rents = new HashSet<RentProduct>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public ProductType ProductType { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerDay { get; set; }

        public byte[] Photo { get; set; }

        public ProductStatus ProductStatus { get; set; }

        public ICollection<OrderProduct> Orders { get; set; }

        public ICollection<RentProduct> Rents { get; set; }
    }
}
