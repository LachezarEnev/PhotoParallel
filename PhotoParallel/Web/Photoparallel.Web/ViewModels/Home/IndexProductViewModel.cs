﻿namespace Photoparallel.Web.ViewModels.Home
{
    public class IndexProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal PricePerDay { get; set; }

        public string ImageUrl { get; set; }

        public bool IsRented { get; set; }

        public int Quantity { get; set; }
    }
}
