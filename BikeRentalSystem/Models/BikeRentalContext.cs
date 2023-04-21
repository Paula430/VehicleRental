using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace BikeRentalSystem.Models
{
    public class BikeRentalContext : DbContext
    {


        public BikeRentalContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Skates> Skates { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Scooter> Scooters { get; set; }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Customer> Customers { get; set; }



    }
}
