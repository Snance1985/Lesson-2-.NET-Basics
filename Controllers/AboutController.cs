using Microsoft.AspNetCore.Mvc;

namespace L02_assignment.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}