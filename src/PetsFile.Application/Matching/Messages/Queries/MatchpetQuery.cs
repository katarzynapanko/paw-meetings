using MediatR;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Matching.Messages.Queries
{
    public record MatchPetQuery : IRequest<IEnumerable<Pet>>
    {
        public Guid PetId { get; }
        public Guid OwnerId { get; }
        public MatchPetQuery(Guid petId, Guid ownerId)
        {
            PetId = petId;
            OwnerId = ownerId;
        }

    }
}
