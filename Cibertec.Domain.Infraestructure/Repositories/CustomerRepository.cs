using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Domain.Infraestructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {


        private static readonly List<Customer> items = [];

        public Task<int> DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertCustomer(Customer customer)
        {
            items.Add(customer);
            return Task.FromResult(customer.Id);
        }

        public Task<int> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        Task<List<Customer>> ICustomerRepository.GetAllCustomers()
        {
            return Task.FromResult(items);
        }
    }
}
