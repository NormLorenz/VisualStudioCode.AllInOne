using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using System.Security.Principal;

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