namespace MobiSell.Models
{
    public class Order_Item
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Product_SKUId { get; set; }
        public Product_SKU Product_SKU { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
