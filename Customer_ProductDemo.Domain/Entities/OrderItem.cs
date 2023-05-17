using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_ProductDemo.Domain.Entities
{
    public class OrderItem
    {
        [Key]
        public int OrderItenId { get; set; }
        [ForeignKey(nameof(CustomerOrder))]
        public int OrderId { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProudctId { get; set; }
        public int OrderQuantity { get; set; }
    }
}
