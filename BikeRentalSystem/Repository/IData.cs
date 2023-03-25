using BikeRentalSystem.Models;
namespace BikeRentalSystem.Repository
{
    public interface IData
    {
        bool AddNewBike(Bike newBike);
        List<Bike> GetAllBikes();
    }
}
