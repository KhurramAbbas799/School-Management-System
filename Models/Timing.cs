using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Timing
    {
        [Key]
        public int TimingId { get; set; }
        public string? TimingName { get; set; }




    }
}
