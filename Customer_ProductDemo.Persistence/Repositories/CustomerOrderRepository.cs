using Customer_ProductDemo.Application.Contracts;
using Customer_ProductDemo.Domain.Entities;
using Customer_ProductDemo.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Persistence.Repositories
{
    internal sealed class CustomerOrderRepository : RepositoryBase<CustomerOrder>, ICustomerOrderRepository
    {
        public CustomerOrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerByName(string FirstName, string LastName, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
