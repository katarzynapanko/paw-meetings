using FluentResults;
using MediatR;
using PetsFile.Application.Owners.Interfaces;

namespace PetsFile.Application.Owners.Messages.Commands.Handlers
{
    public class RegisterOwnerAddressCommandHandler : IRequestHandler<RegisterOwnerAddressCommand, Result>
    {
        private readonly IOwnerAddressWriter _ownerAddressWriter;

        public RegisterOwnerAddressCommandHandler(IOwnerAddressWriter ownerAddressWriter)
        {
            _ownerAddressWriter = ownerAddressWriter;
        }

        public async Task<Result> Handle(RegisterOwnerAddressCommand request, CancellationToken cancellationToken)
        {
            var ownerAddressCreationResult = await _ownerAddressWriter.WriteAsync(request);
            if (ownerAddressCreationResult.IsFailed)
            {
                return ownerAddressCreationResult;
            }
            return Result.Ok();
        }
    }
}
