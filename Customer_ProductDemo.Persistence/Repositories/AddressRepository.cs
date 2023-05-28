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
    internal sealed class AddressRepository : RepositoryBase<Address>, IAddressRepository

    {
        public AddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressByAddressId(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAddressAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
