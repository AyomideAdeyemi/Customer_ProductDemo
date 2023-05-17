using System.ComponentModel.DataAnnotations;


namespace Customer_ProductDemo.Domain.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Building number is a required field")]
        [MaxLength(50)]
        public string? BuildingNumber { get; set; }
        [Required(ErrorMessage = "Street name is a required field")]
        [MaxLength(100)]
        public string? StreetName { get; set; }
        [Required(ErrorMessage = "Area Locality is a required field")]
        [MaxLength(50)]
        public string? ArearLocality { get; set; }
        [Required(ErrorMessage = "State is a required field")]
        [MaxLength(50)]
        public string? State { get; set; }
    }
}
