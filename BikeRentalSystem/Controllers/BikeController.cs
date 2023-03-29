using Microsoft.AspNetCore.Mvc;
using BikeRentalSystem.Repository;
using Microsoft.Extensions.Caching.Memory;

namespace BikeRentalSystem.Controllers
{
    public class BikeController : Controller
    {
        private readonly IData data;
        private IMemoryCache cache;

        public BikeController(IData _data, IMemoryCache memoryCache)
        {
            data = _data;
            cache = memoryCache;
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

