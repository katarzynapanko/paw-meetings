
using FluentValidation;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Owners.Validators
{
    public class OwnerRegistrationModelValidator : AbstractValidator<RegisterOwnerCommand>
    {
        public OwnerRegistrationModelValidator()
        {
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage($"{nameof(RegisterOwnerCommand.DateOfBirth)} cannot be empty.");
            RuleFor(x => x.DateOfBirth).LessThan(DateTime.UtcNow.Date.AddYears(-18)).WithMessage("Owner cannot be younger than 18 yo");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty.");

        }
    }
}
