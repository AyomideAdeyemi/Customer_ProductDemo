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
        Task<Address> GetAddressByNameAsync(string streetName, string arealocality, bool trackChanges);
        void CreateAddress(Address address);
        void DeleteAddress(Address address);
    }
}