using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cis174_CoreApp2.Models;

namespace Cis174_CoreApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string cat, int num)
        {
            return Content("Home controller, Index action, " + "Category " + cat + ", Page " + num);
        }
        [Route("action")]
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }
    }
}
