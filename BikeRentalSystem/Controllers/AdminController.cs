using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
