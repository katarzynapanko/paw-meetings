using FluentResults;
using PetsFile.Application.Pets.Messages.Queries;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Pets.Interfaces
{
    public interface IPetReader
    {
        Task<Result<List<Pet>>> GetAsync(CancellationToken cancellationToken);
    }
}