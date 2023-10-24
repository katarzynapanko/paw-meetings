using FluentResults;
using MediatR;
using PetsFile.Domain.Owners.Entities;

namespace PetsFile.Application.Owners.Messages.Commands
{
    public class RegisterOwnerCommand : IRequest<Result>
    {
        public DateTime DateOfBirth { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Surname { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
        public string Street { get; init; } = string.Empty;
        public string District { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
        public string Country { get; init; } = string.Empty;
        public string PostalCode { get; init; } = string.Empty;

        public Owner ToOwner()
        {
            var owner = new Owner
            {
                DateOfBirth = DateOfBirth,
                DateOfRegistration = DateTime.UtcNow,
                Email = Email,
                Password = Password,
                Name = Name,
                Surname = Surname
            };
            owner.OwnerAddresses.Add(new OwnerAddress
            {
                Street = Street,
                District = District,
                City = City,
                Country = Country,
                PostalCode = PostalCode,
                OwnerId = owner.Id
            });
            return owner;
        }
    }
}
