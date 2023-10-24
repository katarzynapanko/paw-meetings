using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Owners.Database
{
    public class OwnerWriter : IOwnerWriter
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public OwnerWriter(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Result> WriteAsync(RegisterOwnerCommand request)
        {
            var ownerEntity = request.ToOwner();
            _dbContext.Owners.Add(ownerEntity);
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
