
using Produtos.Data.Entities;

namespace Produtos.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set; }

        public ProductViewModel(Product product, List<Product> products)
        {
            Product = product;
            Products = products;
        }
    }
}