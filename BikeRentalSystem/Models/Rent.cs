using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeRentalSystem.Models
{
    public class Rent
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime rentStart { get; set; }
        [Required]
        public DateTime rentStop { get; set; }
        [Required]
        public int vehicleId { get; set; }
        public string firstNameDriver { get; set; }
        public string secondNameDriver { get; set; }
        [Required]
        public string emailDriver { get; set; }
        public string PhoneNumberDriver { get; set; }

    }

    public class RentValidator : AbstractValidator<Rent>
    {
        public RentValidator()
        {
            RuleFor(r => r.rentStart)
                .NotEmpty().WithMessage("Date is required.");

            RuleFor(r => r.rentStop)
                .NotEmpty().WithMessage("Date is required.")
                .GreaterThanOrEqualTo(r => r.rentStart).WithMessage("Rent stop must be greater or equal to rent start");

            RuleFor(r => r.vehicleId)
                .NotEmpty().WithMessage("Vehicle Id is required")
                .GreaterThan(0).WithMessage("Vehicle id must be greater then 0.");

            RuleFor(r => r.emailDriver)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email");
        }
    }
}
