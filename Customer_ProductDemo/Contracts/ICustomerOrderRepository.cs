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
        Task<IEnumerable<CustomerOrder>> GetAllCustomerOrderAsync(bool trackChanges);
        Task<CustomerOrder> GetCustomerOrderByOrderStatusCode(string  orderstatuscode, bool trackChanges);
        void CreateCustomerOrder(CustomerOrder customerOrder);
        void DeleteCustomerOrder(CustomerOrder customerOrder);
    }
}
