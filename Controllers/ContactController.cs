using Microsoft.AspNetCore.Mvc;

namespace L02_assignment.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
        }

        public IActionResult Index()
        {
            ViewBag.Name = "Sean Nance";
            ViewBag.Email = "spnance1985@gmail.com";
            ViewBag.PhoneNumber = "360-910-4719";
            return View();
        }

    }
}
