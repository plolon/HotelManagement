using System.Collections.ObjectModel;
using HotelManagement.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("Users")]
    public class User : BaseDomainEntity
    {
        [StringLength((64))] public string Username { get; set; }

        [StringLength(128)] public string Password { get; set; }

        [StringLength(64)] public string Email { get; set; }

        public string Role { get; set; }
    }
}