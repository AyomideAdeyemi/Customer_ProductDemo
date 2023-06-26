using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.OrderItem
{
    public class OrderItemForCreationDto
    {
        [Key]
        public int OrderItemId { get; set; }

        [ForeignKey(nameof(CustomerOrder))]
        [Column(Order = 1)] // Specify the order of the foreign key properties
        public int OrderId { get; set; }

        [ForeignKey(nameof(Product))]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        public int OrderQuantity { get; set; }
    }
}
