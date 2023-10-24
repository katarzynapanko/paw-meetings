using FluentResults;
using PetsFile.Application.PetsMetadata.Messages.Commands;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface IPetTypeWriter
    {
        Task<Result> WriteAsync(SavePetTypeCommand request);
    }
}