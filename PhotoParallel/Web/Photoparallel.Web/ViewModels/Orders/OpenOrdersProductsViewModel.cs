namespace Photoparallel.Web.ViewModels.Orders
{
    public class OpenOrdersProductsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int OrderQuantity { get; set; }

        public decimal TotalPrice { get; set; }

        public string ImageUrl { get; set; }
    }
}
