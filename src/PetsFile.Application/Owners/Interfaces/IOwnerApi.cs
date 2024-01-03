using FluentResults;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Application.Owners.Interfaces
{
    public interface IOwnerApi
    {
        Task<Result> CreateOwner(RegisterOwnerCommand request);
    }
}