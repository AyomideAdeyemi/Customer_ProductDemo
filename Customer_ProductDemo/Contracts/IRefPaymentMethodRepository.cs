using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Contracts
{
    public interface IRefPaymentMethodRepository
    {
        Task<IEnumerable<RefPaymentMethod>> GetAllAsync(bool trackChanges);
    }
}
