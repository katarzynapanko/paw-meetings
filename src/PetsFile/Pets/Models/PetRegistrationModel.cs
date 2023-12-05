using PetsFile.Application.Pets.Messages.Commands;
using PetsFile.Domain.Pets.Enums;
using PetsFile.Domain.Pets.ValueObjects;

namespace PetsFile.Pets.Models
{
    public class PetRegistrationModel
    {
        public PetTypeId TypeId { get; set; }
        public OwnerId OwnerId { get; set; }
        public TraitId[] TraitId { get; set; } = Array.Empty<TraitId>();
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; } = string.Empty;
        public PetGender Gender { get; set; }
        public IFormFile Photo { get; set; } = default!;


        public async Task<SavePetCommand> ToCommand()
        {
            var command = new SavePetCommand(DateOfBirth, Name, Gender, TypeId, OwnerId, TraitId);
            await command.AddPhoto(Photo); 
            return command;
        }
    }
}