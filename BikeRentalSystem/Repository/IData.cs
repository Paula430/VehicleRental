using BikeRentalSystem.Models;
namespace BikeRentalSystem.Repository
{
    public interface IData
    {
        List<Bike> GetAllBikes();
        List<Scooter> GetAllScooters();
        List<Skates> GetAllSkates();

        Bike GetBike(int id);
        Scooter GetScooter(int id);
        Skates GetSkates(int id);


        bool AddNewVehicle(Vehicle newVehicle);
        string SaveImage(IFormFile file, string folderName);
        bool DeleteVehicle(int Id);
        public bool AddRent(Rent rent);
        public bool DeleteRent();
        
    }
}
