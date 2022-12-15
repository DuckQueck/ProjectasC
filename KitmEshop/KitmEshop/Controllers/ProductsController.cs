using Microsoft.AspNetCore.Mvc;
using InternalServices;

namespace KitmEshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _services;
        public ProductsController(IProductServices services)
        {
            _services = services;
        }
        [HttpGet]
        public IActionResult Get()
         {
            //var result = _db.Products.Include(r => r.Reviews).ToList();
            var result = _services.GetProducts();
            return Ok(result);
        }
    }
}
