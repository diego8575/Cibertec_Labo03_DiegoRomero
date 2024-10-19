using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Domain.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
       public CustomerValidator() { 
        
       

            RuleFor(x=>x.Phone).Length(8, 10).WithMessage("El telefono debe tener entre 8 y 10 caracteres");

            RuleFor(x => x.Email).EmailAddress().WithMessage("El email no es valido");

            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre no puede estar vacio");

            RuleFor(x => x.Password).Matches(@"^[a-zA-Z]\w{3,14}$").WithMessage("Contraseña debil");
        }



    }
}
