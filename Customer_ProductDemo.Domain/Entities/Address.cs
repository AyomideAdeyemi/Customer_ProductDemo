using System.ComponentModel.DataAnnotations;


namespace Customer_ProductDemo.Domain.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string? BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? ArearLocality { get; set; }
        public string? State { get; set; }
    }
}
