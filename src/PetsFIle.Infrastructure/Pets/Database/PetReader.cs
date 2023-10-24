using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Domain.Pets.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Pets.Database
{
    public class PetReader : IPetReader
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public PetReader(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result<List<Pet>>> GetAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await _dbContext.Pets.ToListAsync(cancellationToken);
            }
            catch (TimeoutException ex)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }

    }
} 
