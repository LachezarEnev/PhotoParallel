namespace Photoparallel.Web.Areas.Administration.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    public class HideProductsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Price per day")]
        public decimal PricePerDay { get; set; }

        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

        [Display(Name = "Sale / Rent")]
        public string ProductStatus { get; set; }
    }
}
