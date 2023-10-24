namespace PetsFile.Application.PetsMetadata.Interfaces
{
    public interface ITraitChecker
    {
        bool CheckIfTraitExist(string traitName);
        bool CheckIfTraitIdExist(Guid[] traitIds);
    }
}