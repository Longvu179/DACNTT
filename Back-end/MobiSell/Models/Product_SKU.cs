namespace MobiSell.Models
{
    public class Product_SKU
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string SKU { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public double FinalPrice { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
