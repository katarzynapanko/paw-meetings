using AutoMapper;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Domain.Owners.Entities;

namespace PetsFIle.Infrastructure.Owners.MapperProfiles
{
    public sealed class OwnerAdressMappingProfile : Profile
    {
        public OwnerAdressMappingProfile()
        {
            CreateMap<RegisterOwnerAddressCommand, OwnerAddress>();

        }
    }
}
