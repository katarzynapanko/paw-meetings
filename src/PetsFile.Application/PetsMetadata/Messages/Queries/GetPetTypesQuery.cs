using FluentResults;
using MediatR;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Messages.Queries
{
    public record GetPetTypesQuery : IRequest<Result<List<PetType>>>
    {
    }
}
