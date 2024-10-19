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
    public class GetAllCustomerHandler(ICustomerRepository customerRepository) : IRequestHandler<GetAllCustomers, List<Customer>>
    {
        public Task<List<Customer>> Handle(GetAllCustomers request, CancellationToken cancellationToken)
        {
            return customerRepository.GetAllCustomers();
        }
    }
}
