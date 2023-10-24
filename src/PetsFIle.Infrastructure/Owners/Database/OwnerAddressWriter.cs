using AutoMapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Domain.Owners.Entities;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.Owners.Database
{
    public class OwnerAddressWriter : IOwnerAddressWriter
    {
        private readonly PawsMeetingsDbContext _dbContext;
        private readonly IMapper _mapper;

        public OwnerAddressWriter(PawsMeetingsDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Result> WriteAsync(RegisterOwnerAddressCommand request)
        {
            var ownerAdress = _mapper.Map<OwnerAddress>(request);
            _dbContext.OwnerAddress.Add(ownerAdress);
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
