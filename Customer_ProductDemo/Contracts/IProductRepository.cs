using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductAsync(bool trackChanges);
        Task<Product> GetProductByProductIdAsync(int productId, bool trackChanges);
        void CreateProduct(Product product );
        void DeleteProduct(Product product);
    }
}
