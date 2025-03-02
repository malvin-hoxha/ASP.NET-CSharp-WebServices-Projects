using System.ComponentModel.DataAnnotations;

namespace YpalREST.Models
{
    public record CreateOrUpdateYpalSchema
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
