using Customer_ProductDemo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.ServiceContract.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomerAsync (bool trackChanges);
        Task<CustomerDto> GetCustomerAsync (string phoneNumber, bool trackChanges);
        Task<CustomerDto> CreateCustomerAsync(CustomerForCreationDto creationDto);
        Task UpdateCustomerAsync(string phoneNumber, CustomerForUpdateDto customerForUpdateDto, bool trackChanges);
        Task DeleteCustomerAsync (string phoneNumber, bool trackChanges);


    }
}
