using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Pets.Interfaces;
using PetsFile.Domain.Pets.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Pets.Database
{
    public class PetWriter : IPetWriter
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public PetWriter(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result> WriteAsync(Pet pet)
        {
            _dbContext.Pets.Add(pet);
            try
            {
               var result = await _dbContext.SaveChangesAsync();
                return result == 0
                    ? Result.Fail("Failed to save changes")
                    : Result.Ok();
            }
            catch(DbUpdateException ex)
            {
                return Result.Fail(new ExceptionalError(ex));
            }
        }

    }
}
