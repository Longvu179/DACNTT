namespace MobiSell.Models
{
    public class Product_Color
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
    }
}
