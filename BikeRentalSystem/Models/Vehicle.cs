using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeRentalSystem.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Wheel { get; set; }
        //[NotMapped]
 
        //public IFormFile VehicleImage { get; set; }

        //public string ImagePath { get; set; }

    }
 

}
