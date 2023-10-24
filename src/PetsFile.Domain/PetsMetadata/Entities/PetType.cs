using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Domain.PetsMetadata.Entities
{
    public sealed class PetType
    {
        public Guid Id { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public string Type { get; init; } = string.Empty;
        public List<Pet> Pets { get; init; } = new List<Pet>();
        public List<PetBlackList> PetBlackLists { get; init; } = new List<PetBlackList>();
        public List<OwnerBlackList> OwnerBlackLists { get; init; } = new List<OwnerBlackList>();


        public PetType() { }
    }
}
