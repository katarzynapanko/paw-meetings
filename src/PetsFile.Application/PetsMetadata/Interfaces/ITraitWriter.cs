using FluentResults;
using PetsFile.Application.PetsMetadata.Messages.Commands;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface ITraitWriter
    {
        Task<Result> WriteAsync(SaveTraitCommand request);
    }
}