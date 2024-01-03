
using FluentValidation;
using PetsFile.Application.Authentication.Messages.Commands;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Owners.Requests;

namespace PetsFile.Authentication.Validators
{
    public class UserRegistrationModelValidator : AbstractValidator<RegisterUserCommand>
    {
        public UserRegistrationModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty.");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Password cannot be shorter than 8 characters");
            RuleFor(x => x.Street).NotEmpty().WithMessage("Street cannot be empty.");
            RuleFor(x => x.City).NotEmpty().WithMessage("City cannot be empty.");
            RuleFor(x => x.District).NotEmpty().WithMessage("District cannot be empty.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country cannot be empty.");
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage("PostalCode cannot be empty.");

        }
    }
}
