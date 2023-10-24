using FluentResults;
using PetsFile.Application.Owners.Messages.Queries;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Interfaces
{
    public interface IOwnerReader
    {
        Task<Result<List<Owner>>> GetAsync(GetOwnerQuery request, CancellationToken cancellationToken);
    }
}