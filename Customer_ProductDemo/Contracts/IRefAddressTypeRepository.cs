using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface IRefAddressTypeRepository
    {
        Task<IEnumerable<RefAddressType>> GetAllAsync(bool trackChanges);
        Task<RefAddressType> GetCustomerByRefAddressTypeId(int Id, bool trackChanges);
        void CreateRefAddressType(RefAddressType entity);
        void DeleteRefAddressType(RefAddressType entity);
    }
}
