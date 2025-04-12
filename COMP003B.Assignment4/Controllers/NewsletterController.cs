using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class NewsletterController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult SignUp(Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }

            return View(newsletter);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
