using Customer_ProductDemo.Domain.Entities;


namespace Customer_ProductDemo.Application.Contracts
{
    public interface IRefPaymentMethodRepository
    {
        Task<ICollection<RefAddressType>> GetAllAsync(bool trackChanges);
        Task<RefPaymentMethod> GetRefPaymentMethodById(int Id, bool trackChanges);
        void CreateRefPaymentMethod(RefPaymentMethod refPaymentMethod);
        void UpdateRefPaymentMethod(RefPaymentMethod refPaymentMethod);
        void DeleteRefPaymentMethod(RefPaymentMethod refPaymentMethod);
    }
}
