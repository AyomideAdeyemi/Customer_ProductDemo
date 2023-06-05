
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_ProductDemo.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey(nameof(RefProductType))]
        public string? ProductTypeCode { get; set; }
        public string? ProductName { get; set; }
        public string? ProductPrice { get; set;}

        public RefProductType? RefProductType { get; set; }
        
        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
