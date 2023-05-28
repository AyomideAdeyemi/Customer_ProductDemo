using Customer_ProductDemo.Application.Contracts;
using Customer_ProductDemo.Domain.Entities;
using Customer_ProductDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Persistence.Repositories
{
    internal sealed class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {
           
        }
        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public void DeleteCustomer(Customer customer) => Delete(customer);

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.CustomerId)
                .ToListAsync();
        }

        public async Task<Customer> GetCustomerByPhoneAsync(string phone, bool trackChanges) =>
            await FindByCondition(x => x.PhoneNumber == phone, trackChanges).FirstOrDefaultAsync();
    }
}
  