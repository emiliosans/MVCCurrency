using Microsoft.AspNetCore.Mvc;

namespace ConversorMonedaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
