using AutoMapper;
using FluentResults;
using MediatR;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Messages.Queries.Handlers
{
    public class GetTraitsQueryHandler : IRequestHandler<GetTraitQuery, Result<List<Trait>>>
    {
        private readonly ITraitReader _traitreader;

        public GetTraitsQueryHandler(ITraitReader traitreader)
        {
            _traitreader = traitreader;
        }

        public async Task<Result<List<Trait>>> Handle(GetTraitQuery request, CancellationToken cancellationToken)
        {
            return await _traitreader.GetAsync(request, cancellationToken);
        }
    }
}
