using Microsoft.AspNetCore.Mvc;

namespace Views_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
