using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("ApplicationUsers")]
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string NormalizedEmail { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set;}
        public string PasswordHash { get; set; }
        public bool EmailConfirmed { get; set; }
    }
}
