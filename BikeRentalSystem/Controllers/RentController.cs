using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
