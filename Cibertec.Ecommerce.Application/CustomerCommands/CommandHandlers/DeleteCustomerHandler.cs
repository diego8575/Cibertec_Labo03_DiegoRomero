using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Application.CustomerCommands.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.CommandHandlers
{
    public class DeleteCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<DeleteCustomer, int>
    {


        public Task<int> Handle(DeleteCustomer request, CancellationToken cancellationToken)
        {
           return customerRepository.DeleteCustomer(request.Id);
        }
    }
}
