namespace Photoparallel.Web.ViewModels.Products
{
    using System.Collections.Generic;

    using Photoparallel.Data.Models.Enums;

    public class DetailsProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerDay { get; set; }

        public int Quantity { get; set; }

        public ProductStatus ProductStatus { get; set; }

        public ICollection<string> ImageUrls { get; set; }
    }
}
