using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Application.CustomerCommands.Queries;
using Cibertec.Ecommerce.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.QueryHandlers
{
    public class GetCustomerByIDHandler(ICustomerRepository customerRepository) : IRequestHandler<GetCustomerById, Customer>
    {
        public Task<Customer> Handle(GetCustomerById request, CancellationToken cancellationToken)
        {
           return customerRepository.GetCustomerById(request.Id);
        }
    }
}
