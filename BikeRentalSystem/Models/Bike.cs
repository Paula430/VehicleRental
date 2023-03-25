using System.ComponentModel.DataAnnotations;
namespace BikeRentalSystem.Models
{
    public class Bike
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]

        public string Size { get; set; }
        [Required]

        public string Wheel { get; set; }   
        [Required]

        public IFormFile BikeImage { get; set; }

        public string ImagePath { get; set; }
    }
}
