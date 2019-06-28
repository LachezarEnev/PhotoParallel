namespace Photoparallel.Data.Models
{
    public class RentProduct
    {
        public int Quantity { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public string RentId { get; set; }

        public Rent Rent { get; set; }
    }
}
