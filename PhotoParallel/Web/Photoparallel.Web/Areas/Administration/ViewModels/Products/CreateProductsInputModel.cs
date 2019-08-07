namespace Photoparallel.Web.Areas.Administration.ViewModels.Products
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;
    using Photoparallel.Data.Models.Enums;

    public class CreateProductsInputModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "\"{0}\" must be between {2} and {1} characters!")]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(2000, MinimumLength = 10, ErrorMessage = "\"{0}\" must be between {2} and {1} characters!")]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "\"{0}\" must be number between {1} and {2}!")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public ProductType ProductType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "\"{0}\" must be between {1} and {2}!")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Price Per Day")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "\"{0}\" must be between {1} and {2}!")]
        public decimal PricePerDay { get; set; }

        [Required]
        [Display(Name = "Product Status")]
        public ProductStatus ProductStatus { get; set; }

        [Required]
        [Display(Name = "Warranty")]
        public WarrantyStatus WarrantyStatus { get; set; }

        [Range(0, 10, ErrorMessage = "\"{0}\" must be between {1} and {2}!")]
        public int? Warranty { get; set; }

        [Required]
        [Display(Name = "Image")]
        [DataType(DataType.ImageUrl)]
        public ICollection<IFormFile> FormImages { get; set; }
    }
}
