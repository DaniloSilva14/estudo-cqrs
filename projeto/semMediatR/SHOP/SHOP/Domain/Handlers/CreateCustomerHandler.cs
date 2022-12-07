using SHOP.Domain.Commands.Requests;
using SHOP.Domain.Commands.Responses;

namespace SHOP.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            // verifica se cliente esta cadastrado
            // valida os dados
            // insere o cliente
            // envia email boas vindas

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Danilo Silva",
                Email = "danilo@mail.com",
                Date = DateTime.Now
            };
        }
    }
}
