using BikeRentalSystem.Models;
using System.Runtime.Versioning;

namespace BikeRentalSystem.Repository
{
    public class Data: IData
    {
        private readonly IConfiguration configuration;
        private readonly string dbcon = "";
        public Data()
        {
            this.configuration = configuration;
            dbcon = this.configuration.GetConnectionString("dbConnection");
        }
        public List<Bike> GetAllBikes()
        {
            List<Bike> bikes = new List<Bike>();
            Bike bike=new Bike();
            bike.Id = 1;
            bike.Wheel = "26";
            bike.Size = "S";
            bikes.Add(bike);
            Bike bike2=new Bike();
            bike2.Id = 2;
            bike2.Wheel = "28";
            bike2.Size = "M/L";
            bikes.Add(bike2);
            return bikes;
        }

        [SupportedOSPlatform("windows")]
        public bool AddNewBike(Bike newbike)
        {
            bool isSaved = false;
            return isSaved;
        }
        

    }
}
