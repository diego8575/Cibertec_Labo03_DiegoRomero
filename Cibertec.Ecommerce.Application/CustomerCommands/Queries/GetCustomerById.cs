using Cibertec.Ecommerce.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.Queries
{
    public class GetCustomerById : IRequest<Customer>
    {

        public int Id { get; set; }
    }
}
