using PetsFile.Application.PetsMetadata.Messages.Commands;
using PetsFile.Domain.Pets.Enums;
using System;

namespace PetsFile.PetsMetadata.Models
{
    public class PetTypeCreationModel
    {
        public string Type { get; set; }


        public PetTypeCreationModel(string type)
        {
            Type = type;
        }

        public SavePetTypeCommand ToCommand()
        {
            return new SavePetTypeCommand(Type);
        }
    }
}