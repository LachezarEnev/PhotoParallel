namespace Photoparallel.Web.Areas.Administration.ViewModels.Products
{
    using System.ComponentModel.DataAnnotations;

    public class ProductsSupplyInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "\"{0}\" must be between {1} and {2}!")]
        public int Quantity { get; set; }
    }
}
