using FluentResults;
using MediatR;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Messages.Queries.Handlers
{
    public class GetPetTypesQueryHandler : IRequestHandler<GetPetTypesQuery, Result<List<PetType>>>
    {
        private readonly IPetTypeReader _petTypeReader;


        public GetPetTypesQueryHandler(IPetTypeReader petTypeReader)
        {
            _petTypeReader = petTypeReader;
        }

        public async Task<Result<List<PetType>>> Handle(GetPetTypesQuery request, CancellationToken cancellationToken)
        {
            return await _petTypeReader.GetAsync(request, cancellationToken);
        }
    }
}
