using SHOP.Domain.Commands.Requests;
using SHOP.Domain.Commands.Responses;

namespace SHOP.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
