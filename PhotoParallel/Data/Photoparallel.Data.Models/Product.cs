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
            this.Images = new HashSet<Image>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public ProductType ProductType { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerDay { get; set; }

        public ProductStatus ProductStatus { get; set; }

        public bool IsRented { get; set; }

        public bool Hide { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<OrderProduct> Orders { get; set; }

        public ICollection<RentProduct> Rents { get; set; }
    }
}
