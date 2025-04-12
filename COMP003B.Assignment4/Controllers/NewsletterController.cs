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

        // POST: Process the form submission
        [HttpPost]
        
        public IActionResult SignUp(Newsletter newsletter)
        {
            if (ModelState.IsValid)
            {
                // Here you would normally save to database
                return RedirectToAction("ThankYou");
            }

            // If we got here, something failed - redisplay form
            return View(newsletter);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
