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
    internal sealed class CustomerAddressHistoryRepository : RepositoryBase<CustomerAddressHistory>, ICustomerAddressHistoryRepository
    {
        public CustomerAddressHistoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCustomerAddressHistory(CustomerAddressHistory customerAddressHistory)
        {
            Create(customerAddressHistory);
        }

        public void DeleteCustomerAddressHistory(CustomerAddressHistory customerAddressHistory)
        {
            Delete(customerAddressHistory);
        }

        public async Task<IEnumerable<CustomerAddressHistory>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.AddressTypeCode)
                .ToListAsync();
        }

        public async Task<CustomerAddressHistory> GetCustomerAddressHistoryByAddressTypeCode(string AddressTypeCode, bool trackChanges) => 
            await FindByCondition(x => x.AddressTypeCode == AddressTypeCode, trackChanges).FirstOrDefaultAsync();
    }
}
