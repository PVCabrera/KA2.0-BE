using System.ComponentModel.DataAnnotations;

namespace KodyAtticBE.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string? Description { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public string? ImageUrl { get; set; }
        
        [Required]
        public string? Color { get; set; }
        
        [Required]
        public string? Year { get; set; }
        
        public bool Available { get; set; }
    }
}
