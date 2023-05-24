using Customer_ProductDemo.Domain.Entities;


namespace Customer_ProductDemo.Application.Contracts
{
    public interface IAddressRepository
    {
        Task<ICollection<Address>> GetAllAsync(bool trackChanges);
        Task<Address> GetAddressById(int Id, bool trackChanges);
        void CreateAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
