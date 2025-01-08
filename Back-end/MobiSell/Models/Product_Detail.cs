namespace MobiSell.Models
{
    public class Product_Detail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public string Specification { get; set; }
        public string Warranty { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Material { get; set; }
        public string Origin { get; set; }
        public string Manufacturer { get; set; }
        public string Manufacturers { get; set; }
        public string Category { get; set; }
    }
}
