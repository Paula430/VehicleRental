using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace BikeRentalSystem.Models
{
    public class Customer :IdentityUser
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]

        public string Email { get; set; } 
        [Required]

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }


    }
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name must not exceed 50 characters.");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^[0-9]{9}$").WithMessage("Invalid phone number format.");

            RuleFor(c => c.Address)
                .MaximumLength(100).WithMessage("Address must not exceed 100 characters.");

        }
    }

}
