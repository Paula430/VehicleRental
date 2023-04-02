using Microsoft.AspNetCore.Mvc;
using BikeRentalSystem.Repository;
using Microsoft.Extensions.Caching.Memory;
using BikeRentalSystem.Models;

namespace BikeRentalSystem.Controllers
{
    public class BikeController : Controller
    {
        private readonly IData data;

        public BikeController(IData _data)
        {
            data = _data;
        }
       
        public IActionResult Index()
        {
            var list=data.GetAllBikes();
            return View(list);
        }
        
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Bike newbike)
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

