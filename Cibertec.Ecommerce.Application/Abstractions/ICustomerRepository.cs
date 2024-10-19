using Cibertec.Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Ecommerce.Application.Abstractions
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomers();

        Task<int> InsertCustomer(Customer customer);

        Task<int> UpdateCustomer(Customer customer);

        Task<int> DeleteCustomer(int id);

        Task<Customer> GetCustomerById(int id);

    }
}
