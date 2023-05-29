using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.ServiceContract.Interfaces
{
    public interface IServiceManager
    {
        ICustomerService CustomerService { get; }
    }
}
