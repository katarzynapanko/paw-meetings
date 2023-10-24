
namespace PetsFile.Domain.Owners.Entities
{
    public class OwnerAddress
    {
        public Guid Id { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public string Street { get; init; } = string.Empty;
        public string District { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
        public string Country { get; init; } = string.Empty;
        public string PostalCode { get; init; } = string.Empty;

        public Guid OwnerId { get; init; }
        public Owner Owner { get; init; } = default!;

        public OwnerAddress()
        {
            DateOfRegistration = DateTime.UtcNow;
            Id = Guid.NewGuid();
        }
    }
}
