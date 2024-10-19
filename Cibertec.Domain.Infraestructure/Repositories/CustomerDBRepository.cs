using Cibertec.Domain.Infraestructure.Context;
using Cibertec.Ecommerce.Application.Abstractions;
using Cibertec.Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Domain.Infraestructure.Repositories
{
    public class CustomerDBRepository : ICustomerRepository
    {

        private readonly EcommerceDBContext _context;


        public CustomerDBRepository(EcommerceDBContext context)
        {
            _context = context;
        }

        public Task<int> DeleteCustomer(int id)
        {
          
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);

            if (customer != null) { 
            
            _context.Customers.Remove(customer);
                return _context.SaveChangesAsync();
            }

            return Task.FromResult(0);
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> InsertCustomer(Customer customer)
        {

            using (_context) {

                using (var trx= _context.Database.BeginTransaction())
                {

                    try
                    {
                _context.Customers.Add(customer);
                        _context.SaveChanges();

                            trx.Commit();
                    }
                    catch (Exception)
                    {
                        trx.Rollback();


                    }

                }

            
            }


            return customer.Id;
        }

        public Task<int> UpdateCustomer(Customer customer)
        {
          _context.Customers.Update(customer);
            return _context.SaveChangesAsync();
        }
    }
}
