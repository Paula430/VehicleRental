using BikeRentalSystem.Models;
using System.Data.Entity;

namespace BikeRentalSystem.Repository
{
    public class Data: IData
    {
       
        private readonly IWebHostEnvironment webHost;
        private readonly BikeRentalContext _context;

        public Data(BikeRentalContext context)
        {
            _context = context;
        }

        public List<Bike> GetAllBikes()
        {
            var data= _context.Bikes.ToList();
            return data;
        }

        public List<Scooter> GetAllScooters()
        {
            var data = _context.Scooters.ToList();
            return data;
        }

        public List<Skates> GetAllSkates()
        {
            List<Skates> skates = new List<Skates>();
            return skates;
        }

        public bool AddNewVehicle(Vehicle newVehicle)
        {
                bool isSaved = false;
                _context.Vehicles.Add(newVehicle);
                _context.SaveChanges();
                return true;           
        }

        public Bike GetBike(int id)
        {
            Bike bike = new Bike();
            return bike;
        }
        public Scooter GetScooter(int id)
        {
            Scooter scooter = new Scooter();
            return scooter;
        }
        public Skates GetSkates(int id)
        {
            Skates skates = new Skates();
            return skates;
        }

        public bool DeleteVehicle(int Id)
        {
            return true;
        }

        public bool AddRent(Rent rent)
        {
            return true;
        }

        public bool DeleteRent()
        {
            return true;
        }



        public string SaveImage(IFormFile file, string folderName)
        {
            string imagePath = "";
            try
            {
                string uploadfolder = Path.Combine(webHost.WebRootPath, "images/"+folderName);
                imagePath = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filepath = Path.Combine(uploadfolder, imagePath);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    file.CopyTo(filestream);
                }
            }
            catch(Exception)
            {
                throw;
            }
            return imagePath;
        }


    }
}
