namespace MobiSell.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Chip { get; set; }
        public string Size { get; set; }
        public string LxWxHxW { get; set; }
        public string Display { get; set; }
        public string FrontCamera { get; set; }
        public string RearCamera { get; set; }
        public string Battery { get; set; }
        public string Charger { get; set; }
        public string Accessories { get; set; }
        public int Quality { get; set; }
        public int Sold { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime DayCreate { get; set; }
        public DateTime DayUpdate { get; set; }
    }
}
