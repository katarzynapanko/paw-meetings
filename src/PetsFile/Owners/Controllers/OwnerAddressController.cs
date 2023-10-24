using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PetsFile.Application.Owners.Messages.Queries;
using PetsFile.Owners.Requests;

namespace PetsFile.Owners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerAddressController : ControllerBase
    {
        private readonly IValidator<OwnerAddressRegistrationRequest> _validator;
        private readonly IMediator _mediator;

        public OwnerAddressController(IValidator<OwnerAddressRegistrationRequest> validator, IMediator mediator)
        {
            _validator = validator;
            _mediator = mediator;
        }

        [HttpPost("register-Owner-adress")]
        public async Task<IActionResult> RegisterOwnerAddress([FromForm] OwnerAddressRegistrationRequest ownerAddress)
        {
            var result = await _validator.ValidateAsync(ownerAddress);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return BadRequest(ModelState);
            }
            await _mediator.Send(ownerAddress.ToCommand());
            return Ok();
        }

        [HttpGet("get-owner-addresses")]
        public async Task<IActionResult> GetOwnerAddresses()
        {
            var query = new GetOwnerAddressQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
