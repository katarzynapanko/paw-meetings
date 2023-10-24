using PetsFile.Application.Pets.Messages.Commands;
using PetsFile.Domain.Pets.Enums;

namespace PetsFile.Pets.Models
{
    public class PetRegistrationModel
    {
        public Guid TypeId { get; set; }
        public Guid OwnerId { get; set; }
        public Guid[] TraitId { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public PetGender Gender { get; set; }
        public IFormFile Photo { get; set; }


        public async Task<SavePetCommand> ToCommand()
        {
            var command = new SavePetCommand(DateOfBirth, Name, Gender, TypeId, OwnerId, TraitId);
            await command.AddPhoto(Photo); 
            return command;
        }
    }
}