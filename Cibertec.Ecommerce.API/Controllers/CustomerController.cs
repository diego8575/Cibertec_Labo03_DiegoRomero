using Cibertec.Ecommerce.Application;
using Cibertec.Ecommerce.Application.CustomerCommands;
using Cibertec.Ecommerce.Application.CustomerCommands.Commands;
using Cibertec.Ecommerce.Application.CustomerCommands.Queries;
using Cibertec.Ecommerce.Domain;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cibertec.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(IMediator mediator,IValidator<Customer> validator) : ControllerBase
    {



        [HttpGet]

        public async Task<IActionResult> Get() {

            return Ok(await mediator.Send(new GetAllCustomers()));
        }




        [HttpPost]

        public async Task<IActionResult> Post([FromBody] CreateCustomer customer) {


            var validationResult = await validator.ValidateAsync(customer.Customer);

            if (!validationResult.IsValid)
            {

                var problemDetails = new ValidationProblemDetails(validationResult.Errors.ToDictionary(x => x.PropertyName, x => new[] { x.ErrorMessage }));
   
                return ValidationProblem(problemDetails);

            }





            await mediator.Send(customer);

            return Created();


        }


        [HttpDelete]

        public async Task<IActionResult> Delete(int id)
        {

            await mediator.Send(new DeleteCustomer { Id =id });

            return NoContent();
        }

        [Route("/byID")]
        [HttpGet]
        public async Task<IActionResult> GetByID(int id)
        {

            //CONVENTION OVER CONFIGURATION 

            return Ok(await mediator.Send(new GetCustomerById { Id=id}));
        }



    }
}
