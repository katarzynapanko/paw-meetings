using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.PetsMetadata.Messages.Queries;
using PetsFile.PetsMetadata.Models;

namespace PetsFile.PetsMetadata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraitController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IValidator<TraitCreationModel> _typeValidator;

        public TraitController(IValidator<TraitCreationModel> typeValidator, IMediator mediator)
        {
            _typeValidator = typeValidator;
            _mediator = mediator;
        }



        [HttpPost("create-trait")]
        public async Task<IActionResult> CreatePetType(TraitCreationModel trait)
        {

            var result = await _typeValidator.ValidateAsync(trait);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            var command = trait.ToCommand();
            await _mediator.Send(command);
            return Ok();
        }

        [HttpGet("get-trait")]
        public async Task<IActionResult> GetTrait()
        {
            var query = new GetTraitQuery();
            var result = await _mediator.Send(query);
            return Ok(result);

        }
    }
}