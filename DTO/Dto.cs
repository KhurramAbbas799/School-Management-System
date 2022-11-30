using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.DTO
{
    public class Dto
    {
        [Key]

        public int RiderId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Contact { get; set; }
        public string? CNIC { get; set; }

        public string? Address { get; set; }

        public string? TransportType { get; set; }

        public string? UserName { get; set; }

        public int? UserId { get; set; }

        public string? Password { get; set; }

    }
}
