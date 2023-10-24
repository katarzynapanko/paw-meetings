using PetsFile.Application.PetsMetadata.Interfaces;
using PetsFIle.Infrastructure.Common.Database;

namespace PetsFIle.Infrastructure.PetsMetadata.Checker
{
    public class TraitChecker : ITraitChecker
    {
        private readonly PawsMeetingsDbContext _dbContext;

        public TraitChecker(PawsMeetingsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CheckIfTraitExist(string traitName)
        {
            return _dbContext.Traits.Any(x => x.Name == traitName);
        }
        public bool CheckIfTraitIdExist(Guid[] traitIds)
        {
            return _dbContext.Traits.Select(x => x.Id).Count(z => traitIds.Contains(z)) == traitIds.Length;
        }
    }
}
