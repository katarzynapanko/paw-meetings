using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Queries;
using PetsFile.Domain.Owners.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Owners.Database
{
    public class OwnerReader : IOwnerReader
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public OwnerReader(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<List<Owner>>> GetAsync(GetOwnerQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _dbContext.Owners.ToListAsync(cancellationToken);
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
