using Customer_ProductDemo.Application.Common;
using Customer_ProductDemo.Application.Contracts;
using Customer_ProductDemo.Domain.Entities;
using Customer_ProductDemo.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<ICustomerOrderRepository> _customerOrderRepository;
        private readonly Lazy<IAddressRepository> _addressRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _customerOrderRepository = new Lazy<ICustomerOrderRepository>(() => new CustomerOrderRepository(repositoryContext));
            _customerAddressHistoryRepository = new Lazy<ICustomerAddressHistoryRepository>(() => new CustomerAddressHistoryRepository(repositoryContext));
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository);
        }
        public ICustomerRepository CustomerRepository => _customerRepository.Value;

        public ICustomerOrderRepository CustomerOrderRepository => _customerOrderRepository.Value;

        public ICustomerAddressHistoryRepository CustomerAddressHistoryRepository => throw new NotImplementedException();

        public IRefOrderStatusCodeRepository RefOrderStatusCodeRepository => throw new NotImplementedException();

        public IRefAddressTypeRepository RefAddressTypeRepository => throw new NotImplementedException();

        public IAddressRepository AddressRepository => throw new NotImplementedException();

        public async Task SaveAsync()
        {
           await _repositoryContext.SaveChangesAsync();
        }
    }
}
