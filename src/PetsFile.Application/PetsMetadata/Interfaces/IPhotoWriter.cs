using FluentResults;
using PetsFile.Application.Pets.Messages.Commands;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface IPhotoWriter
    {
        Task<Result> SavePhotoAsync(SavePetCommand request, CancellationToken cancellationToken);
    }
}