using System.ComponentModel.DataAnnotations;

namespace StudentRest.Models
{
    public record CreateOrUpdateStudentSchema
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
