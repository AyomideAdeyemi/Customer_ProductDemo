using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAllAddressAsync(bool trackChanges);
        Task<Address> GetAddressByAddressId(int Id, bool trackChanges);
        void CreateAddress(Address entity);
        void DeleteAddress(Address entity);
    }
}
