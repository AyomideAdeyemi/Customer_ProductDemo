using Customer_ProductDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.Common
{
    public interface IRepositoryManager
    {
        IAddressRepository AddressRepository();
        IOrderItemRepository OrderItemRepository();
        IProductRepository ProductRepository();
        IRefPaymentMethodRepository RefPaymentMethodRepository();
        IRefProductTypeRepository RefProductTypeRepository();
        Task SaveAsync();
    }
}
