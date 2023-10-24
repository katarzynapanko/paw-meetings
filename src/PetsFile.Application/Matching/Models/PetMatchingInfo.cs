using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Matching.Models
{
    public class PetMatchingInfo
    {
        public IEnumerable<Guid> Traits { get; init; } = Enumerable.Empty<Guid>();
        public IEnumerable<OwnerAddress> OwnerAddresses { get; set; } = Enumerable.Empty<OwnerAddress>();
        public IEnumerable<Guid> PetBlackList { get; set; } = Enumerable.Empty<Guid>();

        public IEnumerable<Guid> OwnerBlackList { get; set; } = Enumerable.Empty<Guid>();
    }
}
