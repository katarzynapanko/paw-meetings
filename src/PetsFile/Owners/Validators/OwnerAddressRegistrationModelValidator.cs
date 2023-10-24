
using FluentValidation;
using PetsFile.Owners.Requests;

namespace PetsFile.Owners.Validators
{
    public class OwnerAddressRegistrationModelValidator : AbstractValidator<OwnerAddressRegistrationRequest>
    {
        public OwnerAddressRegistrationModelValidator()
        {
            RuleFor(x => x.Street).NotEmpty().WithMessage("Street cannot be empty.");
            RuleFor(x => x.City).NotEmpty().WithMessage("City cannot be empty.");
            RuleFor(x => x.District).NotEmpty().WithMessage("District cannot be empty.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country cannot be empty.");
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage("PostalCode cannot be empty.");

        }
    }
}
