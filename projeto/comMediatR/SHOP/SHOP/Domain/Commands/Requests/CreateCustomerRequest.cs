using MediatR;
using SHOP.Domain.Commands.Responses;

namespace SHOP.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
