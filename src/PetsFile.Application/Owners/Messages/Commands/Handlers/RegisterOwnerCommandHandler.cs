using FluentResults;
using MediatR;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Application.PetsMetadata.Interfaces;

namespace PetsFile.Application.Owners.Messages.Commands.Handlers
{
    public class RegisterOwnerCommandHandler : IRequestHandler<RegisterOwnerCommand, Result>
    {
        private readonly IOwnerWriter _ownerWriter;

        public RegisterOwnerCommandHandler(IOwnerWriter ownerWriter)
        {
            _ownerWriter = ownerWriter;
        }

        public async Task<Result> Handle(RegisterOwnerCommand request, CancellationToken cancellationToken)
        {
            var ownerCreationResult = await _ownerWriter.WriteAsync(request);
            if (ownerCreationResult.IsFailed)
            {
                return ownerCreationResult;
            }
            return Result.Ok();
        }
    }
}
