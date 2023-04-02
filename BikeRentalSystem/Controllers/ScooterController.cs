using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class ScooterController : Controller
    {

        private readonly IData data;

        public ScooterController(IData _data)
        {
            data = _data;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Scooter newbike)
        {
            if (!ModelState.IsValid)
            {
                return View(newbike);
            }
            bool isSaved = data.AddNewVehicle(newbike);
            ViewBag.IsSaved = isSaved;
            ModelState.Clear();
            return View();
        }


    }
}
