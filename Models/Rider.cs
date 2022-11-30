using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Rider
    {
        [Key]
        public int RiderId { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Contact { get; set; }
        public string? CNIC { get; set; }
        public string? Address { get; set; }
        public string? TransportType{ get; set; }
        public int UserId { get; set; }

    }
}
