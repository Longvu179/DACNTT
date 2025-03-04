using System.ComponentModel.DataAnnotations;

namespace MobiSell.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Street { get; set; }
        public bool Default { get; set; }
    }
}
