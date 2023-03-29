using BikeRentalSystem.Models;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Hosting;


namespace BikeRentalSystem.Repository
{
    public class Data: IData
    {
        private readonly IConfiguration configuration;
        private readonly string dbcon = "";
        private readonly IWebHostEnvironment webHost;

        public Data()
        {
            this.configuration = configuration;
            dbcon = this.configuration.GetConnectionString("dbConnection");
        }

        [SupportedOSPlatform("windows")]

        public List<Bike> GetAllBikes()
        {
            List<Bike> bikes = new List<Bike>();
            return bikes;
        }
        public List<Scooter> GetAllScooters()
        {
            List<Scooter> scooters= new List<Scooter>();
            return scooters;
        }
        public List<Skates> GetAllSkates()
        {
            List<Skates> skates = new List<Skates>();
            return skates;
        }

        [SupportedOSPlatform("windows")]
        public bool AddNewVehicle(Vehicle newVehicle)
        {
            bool isSaved = false;
            try
            {
                //open con
                newVehicle.ImagePath = SaveImage(newVehicle.VehicleImage, "vehicles");
                
                if (newVehicle is Bike)
                {
                    

                }
                else if (newVehicle is Scooter)
                {
                    isSaved = true;

                }
                else
                {
                    isSaved = true;

                }

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                //close con 
            };

            return isSaved;
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

        public bool AddRent()
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
