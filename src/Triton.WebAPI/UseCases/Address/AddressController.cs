using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using Triton.Application.UseCases.Address;
using Triton.Application.UseCases.Address.Models;

namespace Triton.WebAPI.UseCases.Address
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        [SwaggerResponse(200, "", typeof(AddressViewModel))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, "Not Fond")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, "Bad Request")]
        public async Task<IActionResult> GetAdressById(int id)
        {
            AddressViewModel output = await _service.GetAdressById(id);

            if (output == null)
            {
                return new NoContentResult();
            }

            return Ok(output);
        }
    }
}
