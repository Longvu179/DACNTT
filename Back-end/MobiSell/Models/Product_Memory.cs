namespace MobiSell.Models
{
    public class Product_Memory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Ram { get; set; }
        public string Rom { get; set; }
    }
}
