using PetsFile.Application.PetsMetadata.Messages.Commands;
using PetsFile.Domain.Pets.Enums;

namespace PetsFile.PetsMetadata.Models
{
    public class TraitCreationModel
    {
        public string Name { get; set; }

        public TraitCreationModel(string name)
        {
            Name = name;
        }

        public SaveTraitCommand ToCommand()
        {
            return new SaveTraitCommand(Name);
        }
    }
}