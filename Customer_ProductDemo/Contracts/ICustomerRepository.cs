using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync(bool trackChanges);
        Task<Customer> GetCustomerByPhoneAsync(string phone, bool trackChanges);
        void CreateCustomer (Customer entity);
        void DeleteCustomer (Customer entity);

    }
}