using AutoMapper;
using PetsFile.Application.Pets.Messages.Commands;
using PetsFile.Domain.Pets.Entities;

namespace PetsFIle.Infrastructure.Pets.MapperProfiles
{
    public sealed class PetMappingProfile : Profile
    {
        public PetMappingProfile()
        {
            CreateMap<SavePetCommand, Pet>();

        }
    }
}
