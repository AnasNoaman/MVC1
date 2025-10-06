using System.ComponentModel.DataAnnotations;

namespace TaskMVC1.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }

        public string? Description { get; set; }
        
    }
}