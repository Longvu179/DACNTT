namespace MobiSell.Models
{
    public class Cart_Item
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int Product_SKUId { get; set; }
        public Product_SKU Product_SKU { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
