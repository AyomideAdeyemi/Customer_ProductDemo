using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface ICustomerOrderRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync(bool trackChanges);
        Task<Customer> GetCustomerByName(string FirstName, string LastName, bool trackChanges);
        void CreateCustomer(Customer entity);
        void DeleteCustomer(Customer entity);
    }
}
