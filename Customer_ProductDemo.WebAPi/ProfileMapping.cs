using AutoMapper;
using Customer_ProductDemo.Application.DTOs.Customer;
using Customer_ProductDemo.Domain.Entities;

namespace Customer_ProductDemo.WebAPi
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping() 
        {
            CreateMap<Customer, CustomerDto> ();
            CreateMap<CustomerForCreationDto, Customer>();
            CreateMap<CustomerForUpdateDto, Customer> ();
        }
    }
}
