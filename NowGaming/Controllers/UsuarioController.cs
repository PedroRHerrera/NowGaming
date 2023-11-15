using Microsoft.AspNetCore.Mvc;

namespace NowGaming.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
