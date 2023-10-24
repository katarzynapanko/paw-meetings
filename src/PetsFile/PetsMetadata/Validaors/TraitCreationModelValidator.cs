using FluentValidation;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.PetsMetadata.Models;

namespace PetsFile.PetsMetadata.Validaors
{
    public class TraitCreationModelValidator : AbstractValidator<TraitCreationModel>
    {
        public TraitCreationModelValidator(ITraitChecker traitChecker)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(X => X.Name).Must(z => !traitChecker.CheckIfTraitExist(z));
        }
    }
}