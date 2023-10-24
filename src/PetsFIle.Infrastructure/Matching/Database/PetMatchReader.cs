using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetsFile.Application.Common.Config;
using PetsFile.Application.Matching.Interfaces;
using PetsFile.Application.Matching.Models;
using PetsFile.Domain.Pets.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Matching.Database
{
    public class PetMatchReader : IPetMatchReader
    {
        private readonly PawsMeetingsDbContext _dbContext;
        private readonly MatchingOptions _matchingOptions;

        public PetMatchReader(PawsMeetingsDbContext dbContext, IOptions<MatchingOptions> matchingOptions)
        {
            _dbContext = dbContext;
            _matchingOptions = matchingOptions.Value;
        }

        public async Task<PetMatchingInfo> GetPetMatchingInfo(Guid petId, Guid ownerId, CancellationToken ct = default)
        {
            var ownerBlackList = await _dbContext.OwnerBlackLists.Where(x => x.OwnerId == ownerId).Select(x => x.PetTypeId).ToArrayAsync();
            return await _dbContext.Pets.Where(x => x.Id == petId)
               .Select(x => new PetMatchingInfo
               {
                   OwnerAddresses = x.Owner.OwnerAddresses.ToList(),
                   Traits = x.PetTraits.Select(x => x.TraitId).ToList(),
                   PetBlackList = x.PetBlackLists.Select(x => x.PetTypeId).ToList(),
                   OwnerBlackList = ownerBlackList
               }).FirstAsync(ct);
        }

        public async Task<IEnumerable<Pet>> GetMatchingPets(PetMatchingInfo petMatchingInfo, CancellationToken ct = default)
        {
            var citiesToMatchTo = petMatchingInfo.OwnerAddresses.Select(z => z.City).ToArray();
            return await _dbContext.Pets
                .Where(pet => pet.Owner.OwnerAddresses.Select(address => address.City).Any(city => citiesToMatchTo.Contains(city)))
                .Where(pet => pet.PetTraits.Select(petTrait => petTrait.TraitId).Count(traitId => petMatchingInfo.Traits.Contains(traitId)) >= 2 ||
                    petMatchingInfo.Traits.Count() == 1 && pet.PetTraits.Select(petTrait => petTrait.TraitId).Contains(petMatchingInfo.Traits.First()) ||
                    pet.PetTraits.Count == 1 && petMatchingInfo.Traits.Contains(pet.PetTraits.First().TraitId))
                .Where(pet => !pet.PetBlackLists.Select(blackList => blackList.PetTypeId).Any(petTypeId => petMatchingInfo.PetBlackList.Contains(petTypeId)))
                .Where(pet => !petMatchingInfo.OwnerBlackList.Contains(pet.PetTypeId))
                .OrderBy(x => EF.Functions.Random())
                .Take(_matchingOptions.NumberOfPetsToFetch)
                .ToListAsync(ct);
        }
    }
}
