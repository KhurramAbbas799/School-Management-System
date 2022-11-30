using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string? TeacherName { get; set; }

       
        public string? TeacherEmail { get; set; }
        public string? TeacherContact { get; set; }
       
        public string? TeacherGender { get; set; }

    }
}
