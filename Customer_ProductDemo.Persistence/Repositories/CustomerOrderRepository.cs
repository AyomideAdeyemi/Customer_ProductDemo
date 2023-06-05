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
    internal sealed class CustomerOrderRepository : RepositoryBase<CustomerOrder>, ICustomerOrderRepository
    {
        public CustomerOrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateCustomerOrder(CustomerOrder customerOrder)
        {
            Create(customerOrder);
        }

        public void DeleteCustomerOrder(CustomerOrder customerOrder) => Delete(customerOrder);

        public async Task<IEnumerable<CustomerOrder>> GetAllCustomerOrderAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                 .OrderBy(x => x.OrderId)
                 .ToListAsync();
        }

        public async Task<CustomerOrder> GetCustomerOrderByOrderId(int orderId, bool trackChanges) => 
            await FindByCondition(x => x.OrderId == orderId, trackChanges).FirstOrDefaultAsync();
        

       
    }
}
       
