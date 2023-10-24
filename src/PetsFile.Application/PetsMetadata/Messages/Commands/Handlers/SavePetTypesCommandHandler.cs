using FluentResults;
using MediatR;
using PetsFile.Application.PetsMetadata.Interfaces;

namespace PetsFile.Application.PetsMetadata.Messages.Commands.Handlers
{
    public class SavePetTypesCommandHandler : IRequestHandler<SavePetTypeCommand, Result>
    {
        private readonly IPetTypeWriter _petTypeWriter; 

        public SavePetTypesCommandHandler(IPetTypeWriter petTypeWriter)
        {
            _petTypeWriter = petTypeWriter;
        }

        public async Task<Result> Handle(SavePetTypeCommand request, CancellationToken cancellationToken)
        {
            var petTypeCreationResult = await _petTypeWriter.WriteAsync(request);
            if (petTypeCreationResult.IsFailed)
            {
                return petTypeCreationResult;
            }
            return Result.Ok();
        }
    }
}
