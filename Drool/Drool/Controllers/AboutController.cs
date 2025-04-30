using Microsoft.AspNetCore.Mvc;

namespace Drool.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
