using AutoMapper;
using PetsFile.Application.PetsMetadata.Messages.Commands;
using PetsFile.Domain.PetsMetadata.Entities;

namespace PetsFIle.Infrastructure.PetsMetadata.MapperProfiles
{
    public sealed class PetTypeMappingProfile : Profile
    {
        public PetTypeMappingProfile()
        {
            CreateMap<SavePetTypeCommand, PetType>();
        }
    }
}
