using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        // Navigation property 
        public IList<Product> Products { get; set; }
        
    }
}
