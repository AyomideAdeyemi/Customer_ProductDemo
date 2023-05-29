using AutoMapper;
using Customer_ProductDemo.Application.Common;
using Customer_ProductDemo.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.ServiceRepository.Services
{
    public  sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _customerService = new Lazy<ICustomerService>(()=> new CustomerService(repository, logger, mapper));
        }
        public ICustomerService CustomerService => _customerService.Value;
    }
}
