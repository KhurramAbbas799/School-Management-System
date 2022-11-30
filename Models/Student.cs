using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? StudentName { get; set; }

        public string? StudentAge { get; set; }
        public string? StudentEmail { get; set; }
        public string? StudentContact { get; set; }
        public string? FatherName { get; set; }
        public string? Gender { get; set; }
       
    }
}
