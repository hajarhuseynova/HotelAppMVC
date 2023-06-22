using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
