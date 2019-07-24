namespace Photoparallel.Web.ViewModels.Rents
{
    using System.Collections.Generic;

    public class OpenRentViewModel
    {
        public OpenRentViewModel()
        {
            this.Products = new List<OpenRentsProductsViewModel>();
        }

        public int Id { get; set; }

        public decimal Guarantee { get; set; }

        public int Days { get; set; }

        public string RentDate { get; set; }

        public string ReturnDate { get; set; }

        public List<OpenRentsProductsViewModel> Products { get; set; }
    }
}
