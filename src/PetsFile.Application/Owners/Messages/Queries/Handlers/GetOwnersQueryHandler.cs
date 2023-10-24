using FluentResults;
using MediatR;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Messages.Queries.Handlers
{
    public class GetOwnersQueryHandler : IRequestHandler<GetOwnerQuery, Result<List<Owner>>>
    {
        private readonly IOwnerReader _ownerReader;

        public GetOwnersQueryHandler(IOwnerReader ownerReader)
        {
            _ownerReader = ownerReader;
        }

        public async Task<Result<List<Owner>>> Handle(GetOwnerQuery request, CancellationToken cancellationToken)
        {
            return await _ownerReader.GetAsync(request, cancellationToken);
        }
    }
}
