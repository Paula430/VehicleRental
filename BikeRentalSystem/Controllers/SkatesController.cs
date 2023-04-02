using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class SkatesController : Controller
    {

        private readonly IData data;

        public SkatesController(IData _data)
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
        public IActionResult Add(Skates newbike)
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
