using MediatR;
using Microsoft.AspNetCore.Mvc;
using SHOP.Domain.Commands.Requests;
using SHOP.Domain.Commands.Responses;

namespace SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
        )
        {
            return mediator.Send(command);
        }
    }
}
