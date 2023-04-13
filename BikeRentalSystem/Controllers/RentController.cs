using AutoMapper;
using BikeRentalSystem.Models;
using BikeRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BikeRentalSystem.Controllers
{
    public class RentController : Controller
    {
        private readonly IMapper mapper;
        private readonly IData data;
        public RentController(IData _data, IMapper _mapper)
        {
            data = _data;
            mapper = _mapper;
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
        public IActionResult Rent(Rent rentVM)
        {
            if (ModelState.IsValid)
            {
                var rent = mapper.Map<Rent>(rentVM);
                data.AddRent(rent);

                return View("Confirmation", rent);
            }

    
            return View(rentVM);
        }
     



    }
}
