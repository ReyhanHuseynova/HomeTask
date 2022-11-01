using Microsoft.AspNetCore.Mvc;

namespace Views_Task.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
