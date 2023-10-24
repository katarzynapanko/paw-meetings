using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Domain.PetsMetadata.Entities
{
    public class PetTrait
    {
        public Guid Id { get; init; }
        public Guid PetId { get; init; }
        public Guid TraitId { get; init; }
        public Pet Pet { get; init; } = default!;
        public Trait Trait { get; init; } = default!;

        public PetTrait(Guid petId, Guid traitId)
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
