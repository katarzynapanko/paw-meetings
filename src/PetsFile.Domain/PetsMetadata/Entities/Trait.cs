using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Domain.PetsMetadata.Entities
{
    public sealed class Trait
    {
        public TraitId Id { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public string Name { get; init; } = string.Empty;

        public List<PetTrait> PetTraits { get; init; } = new List<PetTrait>();

        public Trait()
        {
            Id = Guid.NewGuid();
        }
    }
}
