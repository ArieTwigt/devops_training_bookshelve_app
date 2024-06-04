using Microsoft.AspNetCore.Mvc;

namespace BookshelfApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
