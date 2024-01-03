using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.Authentication;
using PetsFile.Application.Authentication.Interfaces;
using PetsFile.Application.Authentication.Messages.Commands;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Authentication.Interfaces;
using PetsFile.Domain.Owners.Entities;
using PetsFile.Domain.Pets.ValueObjects;
using System.Net;

namespace PetsFile.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IValidator<RegisterUserCommand> _validator;
        private readonly IMediator _mediator;
        private readonly ILoginService _loginService;

        public AuthenticateController(
            UserManager<IdentityUser> userManager, IMediator mediator, IValidator<RegisterUserCommand> validator, ILoginService loginService)
        {
            _userManager = userManager;
            _mediator = mediator;
            _validator = validator;
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var result = await _loginService.Login(model);
            return result.IsSuccess
                ? Ok(result.Value)
                : Problem(statusCode: (int)HttpStatusCode.InternalServerError);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserCommand user)
        {
            var valudationResult = await _validator.ValidateAsync(user);
            if (!valudationResult.IsValid)
            {
                foreach (var error in valudationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            var result = await _mediator.Send(user);
            return result.IsSuccess
                ? Ok()
                : Problem(statusCode: (int)HttpStatusCode.InternalServerError);
        }
    }
}
