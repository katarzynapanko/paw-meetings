using AutoMapper;
using Azure.Core;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Application.PetsMetadata.Messages.Commands;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.PetsMetadata.Database
{
    public class TraitWriter : ITraitWriter
    {
        private readonly PawsMeetingsDbContext _dbContext;
        private readonly IMapper _mapper;

        public TraitWriter(PawsMeetingsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Result> WriteAsync(SaveTraitCommand request)
        {
            var trait = _mapper.Map<Trait>(request);
            _dbContext.Traits.Add(trait);
            try
            {
                var result = await _dbContext.SaveChangesAsync();
                return result == 0
                    ? Result.Fail("Failed to save changes")
                    : Result.Ok();
            }
            catch (DbUpdateException ex)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }

    }
}
