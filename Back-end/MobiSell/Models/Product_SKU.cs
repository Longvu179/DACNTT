using System.ComponentModel.DataAnnotations.Schema;

namespace MobiSell.Models
{
    public class Product_SKU
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string SKU { get; set; }
        public string RAM_ROM { get; set; }
        public string Color { get; set; }
        public double DefaultPrice { get; set; }
        public double DiscountPercentage { get; set; }
        public double FinalPrice { get; set; }
        public string ImageName { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }
        public bool Default { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
