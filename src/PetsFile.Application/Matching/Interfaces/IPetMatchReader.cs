using PetsFile.Application.Matching.Models;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Application.Matching.Interfaces
{
    public interface IPetMatchReader
    { 
        Task<IEnumerable<Pet>> GetMatchingPets(PetMatchingInfo petMatchingInfo, CancellationToken ct = default);
        Task<PetMatchingInfo> GetPetMatchingInfo(PetId petId, OwnerId ownerId, CancellationToken ct = default);
    }
}