using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Scooter : Vehicle
    {
        [Required]
        public bool Electric { get; set; }
        [Required]
        public int Hight { get; set; }
       
    }

   
}
