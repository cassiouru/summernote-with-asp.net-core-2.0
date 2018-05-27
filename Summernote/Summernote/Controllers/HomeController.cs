using Microsoft.AspNetCore.Mvc;
using Summernote.Models.Home;

namespace Summernote.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            return View("ViewRichText", model);
        }
    }
}
