using Cibertec.Ecommerce.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.Commands
{
    public class CreateCustomer : IRequest<int>
    {

        
        public required Customer Customer { get; set; }

    }
}
