using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Domain.Matching.Entities
{
    public sealed class OwnerBlackList
    {
        public Guid Id { get; init; }
        public Guid OwnerId { get; init; }
        public Guid PetTypeId { get; init; }

        public Owner Owner { get; init; } = default!;
        public PetType PetType { get; init; } = default!;

        public OwnerBlackList()
        {
            Id = Guid.NewGuid();
        }
    }

}
