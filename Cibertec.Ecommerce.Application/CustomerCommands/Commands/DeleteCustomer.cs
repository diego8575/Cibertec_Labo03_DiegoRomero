using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.CustomerCommands.Commands
{
    public class DeleteCustomer : IRequest<int>
    {
        public required int Id { get; set; }
    }
}
