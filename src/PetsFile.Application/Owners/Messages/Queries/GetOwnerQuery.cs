using FluentResults;
using MediatR;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Messages.Queries
{
    public record GetOwnerQuery : IRequest<Result<List<Owner>>>
    {
    }
}
