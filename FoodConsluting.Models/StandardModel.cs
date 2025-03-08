using System.ComponentModel.DataAnnotations;

namespace FoodConsluting.Models
{
    
    public class StandardModel 
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime ImplementTime{ get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime DateCreatedAt { get; set; }
        public DateTime DateUpdatedAt { get; set; }
        public bool Active { get; set; }
    
    }
}
