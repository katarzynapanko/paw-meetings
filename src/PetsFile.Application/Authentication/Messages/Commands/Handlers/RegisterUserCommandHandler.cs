using AutoMapper;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Identity;
using PetsFile.Application.Authentication.Interfaces;
using PetsFile.Application.Owners.Interfaces;
using PetsFile.Application.Owners.Messages.Commands;

namespace PetsFile.Application.Authentication.Messages.Commands.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Result>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IOwnerApi _ownerApi;
        private readonly IMapper _mapper;
        private readonly IIdentityUserFactory _identityUserFactory;

        public RegisterUserCommandHandler(UserManager<IdentityUser> userManager, 
            IOwnerApi ownerApi, IMapper mapper, IIdentityUserFactory identityUserFactory)
        {
            _userManager = userManager;
            _ownerApi = ownerApi;
            _mapper = mapper;
            _identityUserFactory = identityUserFactory;
        }

        public async Task<Result> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var userExists = await _userManager.FindByEmailAsync(request.Email);
            if (userExists != null)
            {
                return Result.Fail("User already exists");
            }
            var user = _identityUserFactory.CreateUser(request);
            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded) 
            {
                return Result.Fail("User creation failed! Please check user details and try again.");
            }
            var command = _mapper.Map<RegisterOwnerCommand>(request);
            command.SetUserId(user.Id);
            var ownerCreationResult = await _ownerApi.CreateOwner(command);
            if (ownerCreationResult.IsFailed)
            {
                await _userManager.DeleteAsync(user);
            }
            return ownerCreationResult;

        }
    }
}
