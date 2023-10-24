using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.Domain.PetsMetadata.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.PetsMetadata.Database
{
    public class PetTypeReader : IPetTypeReader
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public PetTypeReader(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<List<PetType>>> GetAsync(GetPetTypesQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _dbContext.PetTypes.ToListAsync(cancellationToken);
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
