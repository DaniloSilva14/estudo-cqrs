using Microsoft.AspNetCore.Mvc;
using SHOP.Domain.Commands.Requests;
using SHOP.Domain.Commands.Responses;
using SHOP.Domain.Handlers;

namespace SHOP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
        )
        {
            return handler.Handle(command);
        }
    }
}
