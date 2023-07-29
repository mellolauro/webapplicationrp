using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProductDto
    {
        [Required, MaxLength(1000)]
        public string Name { get; set; } = "";

        [Required, MaxLength(1000)]
        public string Brand { get; set; } = "";

        [Required, MaxLength(1000)]
        public string Category { get; set; } = "";

        [Required]
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}
