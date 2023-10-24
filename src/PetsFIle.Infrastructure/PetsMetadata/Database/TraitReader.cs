using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.PetsMetadata.Database
{
    public class TraitReader : ITraitReader
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public TraitReader(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<List<Trait>>> GetAsync(GetTraitQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _dbContext.Traits.ToListAsync(cancellationToken);
                var outcome = result.Count == 0
                    ? Result.Fail("Failed to fetch data")
                    : Result.Ok(result);
                return outcome.Value;
            }
            catch (TimeoutException ex)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }

    }
}
