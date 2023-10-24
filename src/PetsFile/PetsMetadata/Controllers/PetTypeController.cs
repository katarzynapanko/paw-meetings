using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.PetsMetadata.Models;

namespace PetsFile.PetsMetadata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<PetTypeCreationModel> _typeValidator;

        public PetTypeController(IValidator<PetTypeCreationModel> typeValidator, IMediator mediator)
        {
            _typeValidator = typeValidator;
            _mediator = mediator;
        }



        [HttpPost("create-pet-type")]
        public async Task<IActionResult> CreatePetType(PetTypeCreationModel petType)
        {

            var result = await _typeValidator.ValidateAsync(petType);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            var command = petType.ToCommand();
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet("get-pet-type")]
        public async Task<IActionResult> GetPetType()
        {
            var query = new GetPetTypesQuery();
            var result = await _mediator.Send(query);
            return Ok(result);

        }
    }
}