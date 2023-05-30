using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItemAsync(bool trackChanges);
        Task<OrderItem> GetOrderItemByOrderItemIdAsync(int OrderItemId, bool trackChanges);
        void CreateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(OrderItem orderItem);
    }
}
