using Microsoft.AspNetCore.Mvc;
using SPEL.Models;

namespace SPEL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            var spel = new Spel { Name = name };
            return View(spel);
        }
    }

}
