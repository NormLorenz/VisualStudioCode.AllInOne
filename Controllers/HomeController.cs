using Microsoft.AspNet.Mvc;

namespace VirtualTrainingTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            System.Console.WriteLine(string.Format("...GET home route index action called"));
            return View();
        }
    }
}