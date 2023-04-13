using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Skates: Vehicle
    {
        [Required]
        public int Size { get; set; }
        [Required]
        public int WheelHardness { get; set; }



    }

    public class SkatesValidator : AbstractValidator<Skates>
    {
        public SkatesValidator()
        {
            RuleFor(s => s.Size).GreaterThan(0).WithMessage("Size must be greater than 0.");
            RuleFor(s => s.WheelHardness).InclusiveBetween(1, 10).WithMessage("Wheel hardness must be between 1 and 10.");
        }
    }

}





