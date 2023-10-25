namespace PetsFile.Domain.PetsMetadata.Entities
{
    public sealed class Trait
    {
        public Guid Id { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public string Name { get; init; } = string.Empty;

        public List<PetTrait> PetTraits { get; init; } = new List<PetTrait>();

        public Trait()
        {
            Id = Guid.NewGuid();
        }
    }
}
