using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Security.Controllers
{
    public class DummyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}