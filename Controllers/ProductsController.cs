using Microsoft.AspNet.Mvc;
using VisualStudioCode.WebAPI.Models;
using System.Linq;

namespace VisualStudioCode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly SalesDbContext _dbContext;
        public ProductsController(SalesDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
 
        // GET api/products
        [HttpGet]
        public object GetProducts()
        {
            System.Console.WriteLine("...GET api/products called");
            
            var products = _dbContext.Products;
            return new {products};
        }

        // GET api/products/5
        [HttpGet("{id:int}")]
        public object GetProduct(int id)
        {
            System.Console.WriteLine(string.Format("...GET api/products/{0} called", id));

            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return new HttpNotFoundResult();
            } 
            return new {product};
        }
    }
}