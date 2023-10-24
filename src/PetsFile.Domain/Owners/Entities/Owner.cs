using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Pets.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsFile.Domain.Owners.Entities
{
    public class Owner
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Surname { get; init; } = string.Empty;
        public DateTime DateOfBirth { get; init; }
        public DateTime DateOfRegistration { get; init; }
        public string Email { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;

        public List<OwnerAddress> OwnerAddresses { get; init; } = new List<OwnerAddress>();
        public List<Pet> Pets { get; init; } = new List<Pet>();
        public List<OwnerBlackList> OwnerBlackLists { get; init; } = new List<OwnerBlackList>(); 

        public Owner()
        {
            Id = Guid.NewGuid();
        }
    }
}
