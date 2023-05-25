using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using Triton.Application.UseCases.Customer.Queries;

namespace Triton.WebAPI.UseCases.Customer
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [SwaggerResponse(200, "", typeof(CustomersOutput))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, "Not Fond")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IActionResult> Customers()
        {
            CustomersOutput output = await _mediator.Send(new CustomersQuery());

            if (output == null)
            {
                return new NoContentResult();
            }

            return Ok(output);
        }
    }
}
