using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.Owners.Messages.Commands;
using PetsFile.Application.Owners.Messages.Queries;
using System.Net;

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
            var valudationResult = await _validator.ValidateAsync(owner);
            if (!valudationResult.IsValid)
            {
                foreach (var error in valudationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            var result = await _mediator.Send(owner);
            return result.IsSuccess
                ? Ok()
                : Problem(statusCode: (int)HttpStatusCode.InternalServerError);
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
