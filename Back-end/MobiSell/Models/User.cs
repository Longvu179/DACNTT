using Microsoft.AspNetCore.Identity;

namespace MobiSell.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
