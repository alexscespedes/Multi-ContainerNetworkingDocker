using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using products_api.Data;

namespace products_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsControllers : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductsControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts() => Ok(_context.Products.ToList());

        [HttpGet]
        public IActionResult CreateProducts(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), product);
        } 
    }
}
