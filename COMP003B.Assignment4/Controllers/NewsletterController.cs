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
        public IActionResult SignUp(Newsletter signup)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou");
            }
            return View(signup);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }

    public class Newsletter
    {
    }
}

