using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Owners.Requests
{
    public class OwnerAddressRegistrationRequest
    {
        public Guid OwnerId { get; init; }
        public string Street { get; init; } = string.Empty;
        public string District { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
        public string Country { get; init; } = string.Empty;
        public string PostalCode { get; init; } = string.Empty;

        public RegisterOwnerAddressCommand ToCommand()
        {
            return new RegisterOwnerAddressCommand(OwnerId,
                Street, District, City, Country, PostalCode);
        }
    }
}