using AutoMapper;
using PetsFile.Application.Authentication.Messages.Commands;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Application.Authentication.MapperProfiles
{
    public sealed class OwnerRegistrationMappingProfile : Profile
    {
        public OwnerRegistrationMappingProfile()
        {
            CreateMap<RegisterUserCommand, RegisterOwnerCommand>();
        }
    }
}
