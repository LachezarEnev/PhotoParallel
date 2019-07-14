namespace Photoparallel.Web.Areas.Administration.ViewModels.Orders
{
    public class OrderProductsViewModel
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public int InStock { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
