using Microsoft.AspNetCore.Mvc;
using BikeRentalSystem.Repository;
using Microsoft.Extensions.Caching.Memory;
using BikeRentalSystem.Models;
using AutoMapper;

namespace BikeRentalSystem.Controllers
{
    public class BikeController : Controller
    {
        private readonly IData data;
        private readonly IMapper mapper;

        public BikeController(IData _data, IMapper _mapper)
        {
            data = _data;
            mapper = _mapper;
        }
       
        public IActionResult Index()
        {
            var bikes=data.GetAllBikes();
            var bikeModels = mapper.Map<List<Bike>>(bikes);
            return View(bikeModels);
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Bike bikeModel)
        {
            var bike = mapper.Map<Bike>(bikeModel);
            var validator=new BikeValidator();
            var validationResult = validator.Validate(bike);

            if (validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            data.AddNewVehicle(bike);
            ModelState.Clear();
            return View();

        }

    }
}

