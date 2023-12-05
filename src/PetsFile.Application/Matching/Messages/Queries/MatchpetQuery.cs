using MediatR;
using PetsFile.Domain.Pets.Entities;
using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Application.Matching.Messages.Queries
{
    public record MatchPetQuery : IRequest<IEnumerable<Pet>>
    {
        public PetId PetId { get; }
        public OwnerId OwnerId { get; }
        public MatchPetQuery(PetId petId, OwnerId ownerId)
        {
            PetId = petId;
            OwnerId = ownerId;
        }
    }
}
