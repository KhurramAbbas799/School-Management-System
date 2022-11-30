using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class SubjectType
    {
        [Key]
        public int SubjectTypeId { get; set; }
        public string? SubjectTypeName { get; set; }




    }
}
