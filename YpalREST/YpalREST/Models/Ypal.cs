using System.ComponentModel.DataAnnotations;

namespace YpalREST.Models
{
    public class Ypal
    {
        [Required]
        public Guid YpalID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
