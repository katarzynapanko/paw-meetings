using PetsFile.Application.Matching.Models;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Matching.Interfaces
{
    public interface IPetMatchReader
    {
        Task<IEnumerable<Pet>> GetMatchingPets(PetMatchingInfo petMatchingInfo, CancellationToken ct = default);
        Task<PetMatchingInfo> GetPetMatchingInfo(Guid petId, Guid ownerId, CancellationToken ct = default);
    }
}