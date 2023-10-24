using FluentResults;
using MediatR;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Messages.Queries
{
    public record GetOwnerAddressQuery : IRequest<Result<List<OwnerAddress>>>
    {
    }
}
