using FluentResults;
using MediatR;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Messages.Queries
{
    public sealed class GetTraitQuery : IRequest<Result<List<Trait>>>
    {
    }
}
