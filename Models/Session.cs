using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        public string? SessionName { get; set; }




    }
}
