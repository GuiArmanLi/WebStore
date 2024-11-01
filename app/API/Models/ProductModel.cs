using System.ComponentModel.DataAnnotations;

namespace Produtos.Models
{
    public class ProductModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Describe { get; set; }
        [Required]
        public double Price { get; set; }
    }
}