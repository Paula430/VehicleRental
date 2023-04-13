using FluentValidation;
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
        [Required]
        public decimal HourlyPrize { get; set; }
        //[NotMapped]
 
        //public IFormFile VehicleImage { get; set; }

        //public string ImagePath { get; set; }

    }

    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(v => v.Type).NotEmpty().WithMessage("The vehicle type is required.");
            RuleFor(v => v.Wheel).NotEmpty().WithMessage("The vehicle wheel is required.");
            RuleFor(v => v.HourlyPrize).NotEmpty().GreaterThan(0).WithMessage("The vehicle hourly prize must be greater than zero.");
        }
    }


}
