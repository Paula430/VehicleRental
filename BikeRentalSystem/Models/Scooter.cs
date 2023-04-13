using FluentValidation;
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

    public class ScooterValidator : AbstractValidator<Scooter>
    {
        public ScooterValidator()
        {
            RuleFor(x => x.Electric)
                .NotNull().WithMessage("Pole 'Electric' jest wymagane.");

            RuleFor(x => x.Hight)
                .NotNull().WithMessage("Pole 'Hight' jest wymagane.")
                .InclusiveBetween(50, 200).WithMessage("Pole 'Hight' musi być między {From} a {To}.");
        }
    }


}
