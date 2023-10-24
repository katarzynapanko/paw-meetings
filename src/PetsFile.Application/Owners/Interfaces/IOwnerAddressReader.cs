using FluentResults;
using PetsFile.Application.Owners.Messages.Queries;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Interfaces
{
    public interface IOwnerAddressReader
    {
        Task<Result<List<OwnerAddress>>> GetAsync(GetOwnerAddressQuery request, CancellationToken cancellationToken);
    }
}