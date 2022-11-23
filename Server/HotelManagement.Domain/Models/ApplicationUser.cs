using Microsoft.AspNetCore.Identity;

namespace Auth.Repository
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}