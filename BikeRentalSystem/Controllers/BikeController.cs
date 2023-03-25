using Microsoft.AspNetCore.Mvc;
using BikeRentalSystem.Repository;

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
            var list = data.GetAllBikes();
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BikeController newbike)
        {
            return View();
        }

    }
}

