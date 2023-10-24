using AutoMapper;
using FluentResults;
using MediatR;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFile.Application.PetsMetadata.Messages.Commands.Handlers
{
    public class SaveTraitCommandHandler : IRequestHandler<SaveTraitCommand, Result>
    {
        private readonly ITraitWriter _traitWriter;

        public SaveTraitCommandHandler(ITraitWriter traitWriter)
        {
            _traitWriter = traitWriter;
        }

        public async Task<Result> Handle(SaveTraitCommand request, CancellationToken cancellationToken)
        {
            var traitCreationResult = await _traitWriter.WriteAsync(request);
            if (traitCreationResult.IsFailed)
            {
                return traitCreationResult;
            }
            return Result.Ok();
        }
    }
}
