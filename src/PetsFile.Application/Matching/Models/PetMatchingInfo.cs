using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Application.Matching.Models
{
    public class PetMatchingInfo
    {
        // TODO: make these collections ReadOnly collections (both the fields and the types)
        public IEnumerable<TraitId> Traits { get; init; } = Enumerable.Empty<TraitId>();
        public IEnumerable<string> Cities { get; set; } = Enumerable.Empty<string>();
        public IEnumerable<PetTypeId> PetBlackList { get; set; } = Enumerable.Empty<PetTypeId>();
        public IEnumerable<PetTypeId> OwnerBlackList { get; set; } = Enumerable.Empty<PetTypeId>();
    }
}
