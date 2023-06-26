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
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICustomerAddressHistoryRepository> _customerAddressHistoryRepository;
        private readonly Lazy<IOrderItemRepository> _orderItemRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _customerOrderRepository = new Lazy<ICustomerOrderRepository>(() => new CustomerOrderRepository(repositoryContext));
            _customerAddressHistoryRepository = new Lazy<ICustomerAddressHistoryRepository>(() => new CustomerAddressHistoryRepository(repositoryContext));
            _addressRepository = new Lazy<IAddressRepository>(() => new AddressRepository(repositoryContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _orderItemRepository = new Lazy<IOrderItemRepository>(() => new OrderItemRepository(repositoryContext));
        }
        public ICustomerRepository CustomerRepository => _customerRepository.Value;

        public ICustomerOrderRepository CustomerOrderRepository => _customerOrderRepository.Value;

        public ICustomerAddressHistoryRepository CustomerAddressHistoryRepository => _customerAddressHistoryRepository.Value;

        public IAddressRepository AddressRepository => _addressRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public IOrderItemRepository OrderItemRepository => _orderItemRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
