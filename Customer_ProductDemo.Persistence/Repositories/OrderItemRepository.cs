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
    internal sealed class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateOrderItem(OrderItem orderItem)
        {
            Create(orderItem);
        }

        public void DeleteOrderItem(OrderItem orderItem)
        {
            Delete(orderItem);
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItemAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.OrderItemId)
                .ToListAsync();
        }

        public async Task<OrderItem> GetOrderItemByOrderItemIdAsync(int OrderItemId, bool trackChanges) => 
            await FindByCondition(x => x.OrderItemId == OrderItemId, trackChanges).FirstOrDefaultAsync();
    }
}
