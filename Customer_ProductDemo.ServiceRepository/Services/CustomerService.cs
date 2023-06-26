using AutoMapper;
using Customer_ProductDemo.Application.Common;
using Customer_ProductDemo.Application.DTOs.Customer;
using Customer_ProductDemo.Domain.Entities;
using Customer_ProductDemo.ServiceContract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.ServiceRepository.Services
{
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CustomerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)

        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto creationDto)
        {
            var customerEntity = _mapper.Map<Customer>(creationDto);
            _repository.CustomerRepository.CreateCustomer(customerEntity);
           await _repository.SaveAsync();

            var customerToReturn = _mapper.Map<CustomerDto>(customerEntity);
            return customerToReturn;
        }

        public async Task DeleteCustomerAsync(string phoneNumber, bool trackChanges)
        {
            var GetCustomer = await _repository.CustomerRepository.GetCustomerByPhoneAsync(phoneNumber, trackChanges);
            _repository.CustomerRepository.DeleteCustomer(GetCustomer);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomerAsync(bool trackChanges)
        {
            var GetCustomerEntities = await _repository.CustomerRepository.GetAllCustomerAsync(trackChanges);

            var customerEntities = _mapper.Map<IEnumerable<CustomerDto>>(GetCustomerEntities);
            return customerEntities;
        }

        public async Task<CustomerDto> GetCustomerAsync(string phoneNumber, bool trackChanges)
        {
            var GetCustomer = await _repository.CustomerRepository.GetCustomerByPhoneAsync(phoneNumber, trackChanges);
            var CustomerEntity = _mapper.Map<CustomerDto>(GetCustomer);
            return CustomerEntity;
        }

        public async Task UpdateCustomerAsync(string phoneNumber, CustomerForUpdateDto customerForUpdateDto, bool trackChanges)
        {
            var GetCustomerDetail = await _repository.CustomerRepository.GetCustomerByPhoneAsync(phoneNumber, trackChanges);
            _mapper.Map(customerForUpdateDto, GetCustomerDetail);
            await _repository.SaveAsync();
        }
    }
}
