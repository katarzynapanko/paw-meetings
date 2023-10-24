using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Application.Owners.Messages.Queries;

namespace PetsFile.Owners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IValidator<RegisterOwnerCommand> _validator;
        private readonly IMediator _mediator;

        public OwnerController(IValidator<RegisterOwnerCommand> validator, IMediator mediator)
        {
            _validator = validator;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterOwner(RegisterOwnerCommand owner)
        {
            var result = await _validator.ValidateAsync(owner);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            await _mediator.Send(owner);
            return Ok();
        }

        [HttpGet("get-owners")]
        public async Task<IActionResult> GetOwners()
        {
            var query = new GetOwnerQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
