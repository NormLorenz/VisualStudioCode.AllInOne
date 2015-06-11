using Microsoft.AspNet.Mvc;
using VisualStudioCode.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace VisualStudioCode.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CodesController : Controller
    {
        private readonly SalesDbContext _dbContext;
        public CodesController(SalesDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
 
        // GET api/codes
        [HttpGet]
        public object GetCodes()
        {
            System.Console.WriteLine("...GET api/codes called");
            
            var codes = _dbContext.Codes; 
            return new {codes};
        }

        // GET api/codes/5
        [HttpGet("{id:int}")]
        public object GetCode(int id)
        {
            System.Console.WriteLine(string.Format("...GET api/codes/{0} called", id));

            var code = _dbContext.Codes.FirstOrDefault(c => c.Id == id);
            if (code == null)
            {
                return new HttpNotFoundResult();
            } 
            return new {code};
        }
    }
}