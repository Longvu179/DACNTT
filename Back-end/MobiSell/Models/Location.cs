namespace MobiSell.Models
{
    public class City
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public List<District> Districts { get; set; } = new();
    }

    public class District
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public List<Ward> Wards { get; set; } = new();
    }

    public class Ward
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
    }

}
