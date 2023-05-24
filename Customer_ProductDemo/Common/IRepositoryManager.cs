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
        ICustomerRepository CustomerRepository { get; }
        ICustomerOrderRepository CustomerOrderRepository { get; }
        ICustomerAddressHistoryRepository CustomerAddressHistoryRepository { get; }
        IRefOrderStatusCodeRepository RefOrderStatusCodeRepository { get; }
        IRefAddressTypeRepository RefAddressTypeRepository { get; }

        Task SaveAsync();



    }

}
