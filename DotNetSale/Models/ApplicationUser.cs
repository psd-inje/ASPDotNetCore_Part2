using Microsoft.AspNetCore.Identity;

namespace DotNetSale.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public string Gender { get; set; }

    }
}
