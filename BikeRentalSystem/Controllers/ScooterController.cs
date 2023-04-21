using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace BikeRentalSystem.Controllers
{
    public class ScooterController : Controller
    {

        private readonly IData data;
        private readonly IMapper mapper;


        public ScooterController(IData _data, IMapper _mapper)
        {
            data = _data;
            mapper= _mapper;

        }

        public IActionResult Index()
        {
            var scooters = data.GetAllScooters();
            var scooterModels = mapper.Map<List<Scooter>>(scooters);
            return View(scooterModels);
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

