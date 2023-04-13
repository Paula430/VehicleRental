using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace BikeRentalSystem.Controllers
{
    public class SkatesController : Controller
    {

        private readonly IData data;
        private readonly IMapper mapper;


        public SkatesController(IData _data, IMapper _mapper )
        {
            data = _data;
            mapper= _mapper;
        }

        public IActionResult Index()
        { 
            var skates = data.GetAllSkates();
            var skateModels = mapper.Map<List<Skates>>(skates);
            return View(skateModels);
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
