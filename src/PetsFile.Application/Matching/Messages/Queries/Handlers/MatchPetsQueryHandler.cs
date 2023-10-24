using MediatR;
using PetsFile.Application.Matching.Interfaces;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Matching.Messages.Queries.Handlers
{
    public class MatchPetsQueryHandler : IRequestHandler<MatchPetQuery, IEnumerable<Pet>>
    {
        private readonly IPetMatchReader _petReader;

        public MatchPetsQueryHandler(IPetMatchReader petReader)
        {
            _petReader = petReader;
        }

        public async Task<IEnumerable<Pet>> Handle(MatchPetQuery request, CancellationToken cancellationToken)
        {
            var petMatchingInfo = await _petReader.GetPetMatchingInfo(request.PetId, request.OwnerId);

            return await _petReader.GetMatchingPets(petMatchingInfo);
        }
    }
}