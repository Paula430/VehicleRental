using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Skates: Vehicle
    {
        [Required]
        public int Size { get; set; }
        [Required]
        public int Wheel { get; set; }
        [Required]
        public string WheelHardness { get; set; }
    }
    
}





