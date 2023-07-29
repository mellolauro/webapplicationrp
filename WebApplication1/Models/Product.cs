using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [MaxLength(1000)]
        public string Name { get; set; } = "";
        
        [MaxLength(1000)] 
        public string Brand { get; set; } = "";
        
        [MaxLength(1000)]
        public string Category { get; set; } = "";

        [Precision(16, 2)]
        public decimal Price { get; set; }
        
        public string Description { get; set; } = "";

        [MaxLength(1000)]
        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}
