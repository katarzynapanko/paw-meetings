using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface ITraitChecker
    {
        bool CheckIfTraitExist(string traitName);
        bool CheckIfTraitIdExist(TraitId[] traitIds);
    }
}