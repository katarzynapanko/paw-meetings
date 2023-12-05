using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Domain.Matching.Entities
{
    public sealed class PetBlackList
    {
        public Guid Id { get; init; }
        public PetId PetId { get; init; }
        public PetTypeId PetTypeId { get; init; }
        public Pet Pet { get; init; } = default!;
        public PetType PetType { get; init; } = default!;

        public PetBlackList()
        {
            Id = Guid.NewGuid();
        }
    }

}
