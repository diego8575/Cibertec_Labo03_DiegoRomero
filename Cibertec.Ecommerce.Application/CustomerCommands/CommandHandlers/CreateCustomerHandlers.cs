using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Application.CustomerCommands.Commands;
using Cibertec.Ecommerce.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.CommandHandlers
{
    public class CreateCustomerHandlers(ICustomerRepository customerRepository) : IRequestHandler<CreateCustomer, int>
    {
        public Task<int> Handle(CreateCustomer request, CancellationToken cancellationToken)
        {

           

            return customerRepository.InsertCustomer(request.Customer);
        }
    }
}
