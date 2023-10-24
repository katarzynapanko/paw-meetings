using FluentResults;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Application.Owners.Interfaces
{
    public interface IOwnerAddressWriter
    {
        Task<Result> WriteAsync(RegisterOwnerAddressCommand request);
    }
}