using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Product
    {
        [Key]
        public int Proid {  get; set; }
        public string? Proname { get; set; }
        public decimal? Price { get; set; }
        public int? catId { get; set; }
        //set navigation property
        [ForeignKey("catId")]
        public Category Category1 { get; set; }
    }
}
