using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class ScooterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
