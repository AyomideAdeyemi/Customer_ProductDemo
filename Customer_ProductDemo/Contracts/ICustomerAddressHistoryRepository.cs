using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface ICustomerAddressHistoryRepository
    {
        Task<IEnumerable<CustomerAddressHistory>> GetAllAsync(bool trackChanges);
        Task<CustomerAddressHistory> GetCustomerAddressHistoryByAddressTypeCode(string AddressTypeCode, bool trackChanges);
        void CreateCustomerAddressHistory(CustomerAddressHistory customerAddressHistory);
        void DeleteCustomerAddressHistory(CustomerAddressHistory customerAddressHistory);
    }
}
