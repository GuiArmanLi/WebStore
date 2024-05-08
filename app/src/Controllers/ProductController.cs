using Microsoft.AspNetCore.Mvc;
using Produtos.Data;
using Produtos.Data.Entities;
using Produtos.Models;

namespace Produtos.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(AppDbContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult GetAll()
        {
            ProductViewModel productsView = new ProductViewModel(new Product(), _context.Products.ToList());

            return View(productsView);
        }

        public IActionResult Create(ProductModel productModel)
        {
            if (productModel is not null)
            {
                var productSearched = _context.Products.FirstOrDefault(x => x.Name == productModel.Name);

                if (productSearched is null)
                {
                    var product = new Data.Entities.Product
                    {
                        Id = Guid.NewGuid(),
                        Name = productModel.Name,
                        Describe = productModel.Describe,
                        Price = productModel.Price
                    };

                    _context.Add(product);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("GetAll", "Product");
        }

        [HttpPost]
        public IActionResult Update(Product request)
        {
            _logger.LogInformation("Product Request: ", request.ToString());
            var product = _context.Products.FirstOrDefault(x => x.Id == request.Id);
            _logger.LogInformation("Product Request: ", request.ToString());

            if (product is not null)
            {
                product.Name = request.Name;
                product.Describe = request.Describe;
                product.Price = request.Price;

                _context.SaveChanges();
            }

            return RedirectToAction("GetAll", "Product");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);

            if (product is not null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction("GetAll", "Product");
        }
    }
}