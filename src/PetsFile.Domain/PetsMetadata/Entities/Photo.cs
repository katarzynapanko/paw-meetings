using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Domain.PetsMetadata.Entities
{
    public class Photo
    {
        public Guid Id { get; init; }
        public string Path { get; init; } = string.Empty;
        public Guid PetId { get; init; }
        public Pet Pet { get; init; } = default!;

        private Photo() { }
        public Photo(Guid petId, string path)
        {
            Id = Guid.NewGuid();
            PetId = petId;
            Path = path;
        }
    }
}