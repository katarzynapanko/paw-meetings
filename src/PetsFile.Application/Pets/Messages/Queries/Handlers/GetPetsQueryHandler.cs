using FluentResults;
using MediatR;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Pets.Messages.Queries.Handlers
{
    public class GetPetsQueryHandler : IRequestHandler<GetPetQuery, Result<List<Pet>>>
    {
        private readonly IPetReader _petReader;

        public GetPetsQueryHandler(IPetReader petReader)
        {
            _petReader = petReader;
        }

        public async Task<Result<List<Pet>>> Handle(GetPetQuery request, CancellationToken cancellationToken)
        {
            return await _petReader.GetAsync(cancellationToken);          
        }
    }
}