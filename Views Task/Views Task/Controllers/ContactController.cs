using Microsoft.AspNetCore.Mvc;

namespace Views_Task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
