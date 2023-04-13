using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Bike : Vehicle
    {
        [Required]
        public string Size { get; set; }

       
    }
    public class BikeValidator : AbstractValidator<Bike>
    {
        public BikeValidator()
        {

            RuleFor(b => b.Size).NotEmpty().WithMessage("Size is required");

        }
    }

}
