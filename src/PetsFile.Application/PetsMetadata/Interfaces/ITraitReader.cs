using FluentResults;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface ITraitReader
    {
        Task<Result<List<Trait>>> GetAsync(GetTraitQuery request, CancellationToken cancellationToken);
    }
}