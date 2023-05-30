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
    internal sealed class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAddress(Address address)
        {
            Create(address);
        }

        public void DeleteAddress(Address address) => Delete(address);


        public async Task<Address> GetAddressByAddressIdAsync(int addressId, bool trackChanges) =>
        
            await FindByCondition(x => x.AddressId==addressId, trackChanges).FirstOrDefaultAsync();
        

        public async Task<IEnumerable<Address>> GetAllAddressAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.AddressId)
                .ToListAsync();
        }
    }
}
