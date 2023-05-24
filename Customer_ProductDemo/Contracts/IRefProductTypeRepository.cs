using Customer_ProductDemo.Domain.Entities;


namespace Customer_ProductDemo.Application.Contracts
{
    public interface IRefProductTypeRepository
    {
        Task<IQueryable<RefProductType>> GetAllAsync(bool trackChanges);
        Task<RefProductType> GetRefProductTypeById(int Id, bool trackChanges);
        void CreateRefProductType(RefProductType refProductType);
        void UpdateRefProductType(RefProductType refProductType);
        void DeleteRefProductType(RefProductType refProductType);
    }
}
