using Microsoft.AspNetCore.Mvc;

namespace SPEL.Controllers
{
    public class SpelControllers : Controller
    {
        public IActionResult Index(int id)
        {
            return new ContentResult { Content  =  id.ToString() };
        }
    }
}
