using FluentResults;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Application.Owners.Interfaces
{
    public interface IOwnerWriter
    {
        Task<Result> WriteAsync(RegisterOwnerCommand request);
    }
}