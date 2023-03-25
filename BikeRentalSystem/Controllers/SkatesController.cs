using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class SkatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
