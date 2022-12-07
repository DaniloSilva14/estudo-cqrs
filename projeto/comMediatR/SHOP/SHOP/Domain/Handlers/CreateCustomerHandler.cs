using MediatR;
using SHOP.Domain.Commands.Requests;
using SHOP.Domain.Commands.Responses;

namespace SHOP.Domain.Handlers
{
    public class CreateCustomerHandler : 
        IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // verifica se cliente esta cadastrado
            // valida os dados
            // insere o cliente
            // envia email boas vindas

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Danilo Silva",
                Email = "danilo@mail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
