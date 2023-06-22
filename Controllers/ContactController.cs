using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
