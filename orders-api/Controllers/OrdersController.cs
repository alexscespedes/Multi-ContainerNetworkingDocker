using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using orders_api.Data;

namespace orders_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders() => Ok(_context.Orders.ToList());

        [HttpGet]
        public IActionResult CreateOrders(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), order);
        } 
    }
}
