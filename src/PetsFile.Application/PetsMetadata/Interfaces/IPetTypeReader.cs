using FluentResults;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface IPetTypeReader
    {
        Task<Result<List<PetType>>> GetAsync(GetPetTypesQuery request, CancellationToken cancellationToken);
    }
}