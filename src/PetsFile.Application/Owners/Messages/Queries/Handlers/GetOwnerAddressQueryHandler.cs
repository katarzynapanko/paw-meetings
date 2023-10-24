using AutoMapper;
using FluentResults;
using MediatR;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Messages.Queries.Handlers
{
    public class GetPetsGetOwnerAddressQueryHandlerQueryHandler : IRequestHandler<GetOwnerAddressQuery, Result<List<OwnerAddress>>>
    {
        private readonly IOwnerAddressReader _ownerAddressReader;

        public GetPetsGetOwnerAddressQueryHandlerQueryHandler(IOwnerAddressReader ownerAddressReader)
        {
            _ownerAddressReader = ownerAddressReader;
        }

        public async Task<Result<List<OwnerAddress>>> Handle(GetOwnerAddressQuery request, CancellationToken cancellationToken)
        {
            return await _ownerAddressReader.GetAsync(request, cancellationToken);
        }
    }
}
