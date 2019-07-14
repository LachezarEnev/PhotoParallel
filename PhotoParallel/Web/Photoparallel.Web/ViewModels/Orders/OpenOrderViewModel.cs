namespace Photoparallel.Web.ViewModels.Orders
{
    using System.Collections.Generic;

    public class OpenOrderViewModel
    {
        public OpenOrderViewModel()
        {
            this.Products = new List<OpenOrdersProductsViewModel>();
        }

        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public List<OpenOrdersProductsViewModel> Products { get; set; }
    }
}
