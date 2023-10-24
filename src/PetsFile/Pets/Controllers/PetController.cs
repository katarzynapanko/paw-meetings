using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.Matching.Messages.Queries;
using PetsFile.Application.Pets.Messages.Queries;
using PetsFile.Pets.Models;
using System.Net;

namespace PetsFile.Pets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<PetRegistrationModel> _validator;

        public PetController(IValidator<PetRegistrationModel> validator, IMediator mediator)
        {
            _validator = validator;
            _mediator = mediator;
        }

        [HttpPost("register-pet")]
        public async Task<IActionResult> RegisterPet([FromForm] PetRegistrationModel pet)
        {
            var result = await _validator.ValidateAsync(pet);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            var command = await pet.ToCommand();
            var operationResult = await _mediator.Send(command);
            return operationResult.IsSuccess
                ? Ok()
                : Problem(string.Join(',', operationResult.Errors.Select(z => z.Message)),
                    statusCode: (int)HttpStatusCode.InternalServerError);
        }
    }
}