using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Domain.Models
{
    [Table("Hotels")]
    public class Hotel
    {
        public int Id { get; set; }
        [StringLength(128)]
        public string Name { get; set; }
        [StringLength(128)]
        public string Country { get; set; }
        [StringLength(128)]
        public string City { get; set; }
        [StringLength(128)]
        public string Street { get; set; }
    }
}
