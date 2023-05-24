using Customer_ProductDemo.Domain.Entities;


namespace Customer_ProductDemo.Application.Contracts
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetAllAsync(bool trackChanges);
        Task<Product> GetByProductId(int ProductId, bool trackChanges);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
