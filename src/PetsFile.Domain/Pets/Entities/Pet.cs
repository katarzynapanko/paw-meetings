using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.Enums;
using PetsFile.Domain.Pets.ValueObjects;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Domain.Pets.Entities
{
    public sealed class Pet
    {
        // TODO: Create a PetId struct instead of a common Guid
        public PetId Id { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public DateTime DateOfBirth { get; init; }
        public string Name { get; init; } = string.Empty;
        public PetGender Gender { get; init; }
        // TODO: Create a PetTypeId struct instead of a common Guid
        public PetTypeId PetTypeId { get; init; }
        // TODO: Create a OwnerId struct instead of a common Guid
        public OwnerId OwnerId { get; init; }

        public PetType PetType { get; init; } = default!;
        public Owner Owner { get; init; } = default!;
        public List<PetTrait> PetTraits { get; init; } = new List<PetTrait>();
        public List<PetBlackList> PetBlackLists { get; init; } = new List<PetBlackList>();
        public List<Photo> Photos { get; init; } = new List<Photo>();

        public Pet()
        {
            Id = Guid.NewGuid();
            DateOfRegistration = DateTime.UtcNow;
        }

        private Pet(DateTime dateOfbirth, string name, PetGender gender, 
            PetTypeId petTypeId, OwnerId ownerId, TraitId[] traitIds, string photoPath)
        {
            Id = Guid.NewGuid();
            DateOfRegistration = DateTime.UtcNow;
            DateOfBirth = dateOfbirth;
            Name = name;
            Gender = gender;
            PetTypeId = petTypeId;
            OwnerId = ownerId;
            foreach (var traitId in traitIds)
            {
                PetTraits.Add(new PetTrait(Id.Value, traitId));
            }
            Photos.Add(new Photo(Id.Value, photoPath));
        }

        public static Pet New(DateTime dateOfbirth, string name, PetGender gender,
            PetTypeId petTypeId, OwnerId ownerId, TraitId[] traitIds, string photoPath)
        {
            return new(dateOfbirth, name, gender, petTypeId, ownerId, traitIds, photoPath);
        }
    }
}
