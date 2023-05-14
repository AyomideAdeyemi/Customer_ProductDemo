
using System.ComponentModel.DataAnnotations;

namespace Customer_ProductDemo.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductTypeCode { get; set; }
        public string? ProductName { get; set; }
        public string? ProductPrice { get; set;}
    }
}
