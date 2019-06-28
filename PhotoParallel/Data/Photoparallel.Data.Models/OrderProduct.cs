namespace Photoparallel.Data.Models
{
    public class OrderProduct
    {
        public int Quantity { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }
    }
}
