using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Domain.Matching.Entities
{
    public sealed class OwnerBlackList
    {
        public Guid Id { get; init; }
        public OwnerId OwnerId { get; init; }
        public PetTypeId PetTypeId { get; init; }

        public Owner Owner { get; init; } = default!;
        public PetType PetType { get; init; } = default!;

        public OwnerBlackList()
        {
            Id = Guid.NewGuid();
        }
    }

}
