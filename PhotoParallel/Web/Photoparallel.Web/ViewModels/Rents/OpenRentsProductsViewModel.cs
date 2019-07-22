namespace Photoparallel.Web.ViewModels.Rents
{
    public class OpenRentsProductsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerDay { get; set; }

        public int RentQuantity { get; set; }

        public string ImageUrl { get; set; }
    }
}
