using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Common
{
    public interface IRepositoryBase <T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        //IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
