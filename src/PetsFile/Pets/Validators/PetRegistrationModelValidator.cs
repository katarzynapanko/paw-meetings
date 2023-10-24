using FluentValidation;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Pets.Models;

namespace PetsFile.Pets.Validators
{
    public class PetRegistrationModelValidator : AbstractValidator<PetRegistrationModel>
    {
        
        public PetRegistrationModelValidator(ITraitChecker traitChecker)
        {
            RuleFor(x => x.TypeId).NotEmpty().WithMessage("Type cannot be empty.");
            RuleFor(x => x.DateOfBirth).NotEmpty().WithMessage($"{nameof(PetRegistrationModel.DateOfBirth)} cannot be empty.");
            RuleFor(x => x.DateOfBirth).GreaterThan(DateTime.UtcNow.Date.AddYears(-50)).WithMessage("Pet cannot be older than 50 yo");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(X => X.TraitId).Must(z => !traitChecker.CheckIfTraitIdExist(z));
        }
    }
} 
