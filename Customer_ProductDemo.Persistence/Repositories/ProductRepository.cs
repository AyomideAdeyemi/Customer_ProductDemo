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
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProduct(Product product)
        {
            Create(product);
        }

        public void DeleteProduct(Product product)
        {
            Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync(bool trackChanges)
        {
           return await FindAll(trackChanges)
                .OrderBy(x => x.ProductId)
                .ToListAsync();
        }

        public async Task<Product> GetProductByProductIdAsync(int productId, bool trackChanges) => 
            await FindByCondition(x => x.ProductId == productId, trackChanges).FirstOrDefaultAsync();
    }
}
