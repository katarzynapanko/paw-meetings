using FluentResults;
using MediatR;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Pets.Messages.Queries
{
    public record GetPetQuery : IRequest<Result<List<Pet>>>
    {
    }
}
