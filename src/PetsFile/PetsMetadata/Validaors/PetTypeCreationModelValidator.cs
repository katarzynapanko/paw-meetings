using FluentValidation;
using PetsFile.PetsMetadata.Models;

namespace PetsFile.PetsMetadata.Validaors
{
    public class PetTypeCreationModelValidator : AbstractValidator<PetTypeCreationModel>
    {
        public PetTypeCreationModelValidator()
        {
            RuleFor(x => x.Type).NotEmpty().WithMessage("Type cannot be empty.");
        }
    }
}
