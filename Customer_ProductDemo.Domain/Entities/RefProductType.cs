using System.ComponentModel.DataAnnotations;

namespace Customer_ProductDemo.Domain.Entities
{
    public class RefProductType
    {
        [Key]
        public string? ProductTypeCode {get; set; }
        public string? ProductTypeDescription { get; set;}
    }
}
