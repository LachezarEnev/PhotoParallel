namespace Photoparallel.Web.ViewModels.Home
{
    using System.Collections.Generic;

    using Photoparallel.Data.Models.Enums;
    using X.PagedList;

    public class IndexViewModel
    {
        public IPagedList<IndexProductViewModel> ProductsViewModel { get; set; }

        public IEnumerable<AllProductsVieModel> Products { get; set; }

        public string SearchString { get; set; }

        public int? PageNumber { get; set; }

        public int? PageSize { get; set; }

        public ProductsSort SortBy { get; set; }

        public string ProductType { get; set; }
    }
}
