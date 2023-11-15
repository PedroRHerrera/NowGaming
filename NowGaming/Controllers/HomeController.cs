using Microsoft.AspNetCore.Mvc;

namespace NowGaming.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Usuario");
        }
    }
}
