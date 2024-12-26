using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(500)]
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public ProductStatus Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
