using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Domain.PetsMetadata.Entities
{
    public class PetTrait
    {
        public Guid Id { get; init; }
        public PetId PetId { get; init; }
        public TraitId TraitId { get; init; }
        public Pet Pet { get; init; } = default!;
        public Trait Trait { get; init; } = default!;

        public PetTrait(PetId petId, TraitId traitId)
        {
            Id = Guid.NewGuid();
            PetId = petId;
            TraitId = traitId;
        }
        public PetTrait()
        {
            Id = Guid.NewGuid();
        }
    }
}
