using FluentResults;
using PetsFile.Application.Pets.Messages.Commands;
using PetsFile.Application.PetsMetadata.Interfaces;

namespace PetsFIle.Infrastructure.PetsMetadata.Database
{
    public class PhotoWriter : IPhotoWriter
    {
        public async Task<Result> SavePhotoAsync(SavePetCommand request, CancellationToken cancellationToken)
        {
            try
            {
                using var fs = File.Create(request.Path);
                await request.PhotoStream.CopyToAsync(fs, cancellationToken);
                fs.Close();
                return Result.Ok();
            }
            catch (Exception ex) when (ex is UnauthorizedAccessException or
                PathTooLongException or DirectoryNotFoundException or IOException)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }
    }
}
