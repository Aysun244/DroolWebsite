using Microsoft.AspNetCore.Mvc;

namespace Drool.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
