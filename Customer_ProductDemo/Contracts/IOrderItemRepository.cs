using Customer_ProductDemo.Domain.Entities;


namespace Customer_ProductDemo.Application.Contracts
{
    public interface IOrderItemRepository
    {
        Task<ICollection<OrderItem>> GetAllAsync(bool trackChanges);
        Task<OrderItem> GetByOrderItemId(int OrderItenId, bool trackChanges);
        void CreateOrderItem(OrderItem orderItem);
        void UpdateOrderItem(OrderItem orderItem);
        void DeleteOrderItem(OrderItem orderItem);
    }
}
