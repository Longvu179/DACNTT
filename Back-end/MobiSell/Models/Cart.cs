namespace MobiSell.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int Total { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
