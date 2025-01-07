namespace MobiSell.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public int Sold { get; set; }
        public DateTime DayCreate { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
