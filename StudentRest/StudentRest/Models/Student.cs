using System.ComponentModel.DataAnnotations;

namespace StudentRest.Models
{
    public class Student
    {
        [Required]
        public Guid StudentID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }


    }
}
