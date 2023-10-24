using FluentResults;
using MediatR;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Pets.Messages.Commands.Handlers
{
    public class SavePetsCommandHandler : IRequestHandler<SavePetCommand, Result>
    {
        private readonly IPetWriter _petWriter;
        private readonly IPhotoWriter _photoWriter;

        public SavePetsCommandHandler(IPetWriter petWriter, IPhotoWriter fileWriter)
        {
            _petWriter = petWriter;
            _photoWriter = fileWriter;
        }

        public async Task<Result> Handle(SavePetCommand request, CancellationToken cancellationToken)
        {
            var pet = Pet.New(request.DateOfBirth, request.Name, request.PetGender,
                request.PetTypeId, request.OwnerId, request.TraitIds, request.Path);
            var petCreationResult = await _petWriter.WriteAsync(pet);
            if (petCreationResult.IsFailed)
            {
                return petCreationResult;
            }
            var photoSavingResult = await _photoWriter.SavePhotoAsync(request, cancellationToken);
            if (photoSavingResult.IsFailed)
            {
                // TODO: Remove created pet from the data store
                return photoSavingResult;
            }
            return Result.Ok();
        }
    }
}
