using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Rent
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public Vehicle vehicle { get; set; }
        [Required]
        public int vehicleId { get; set; }
        public string firstNameDriver { get; set; }
        public string secondNameDriver { get; set; }
        [Required]
        public string emailDriver { get; set; }
        public string PhoneNumberDriver { get; set; }
        [Required]
        public bool IsLent { get; set; }

    }

   

}
