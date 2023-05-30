using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Domain.Entities
{
    public class CustomerOrder
    {
        [Key]
        public int OrderId { get; set; }

        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set;}

        [Required (ErrorMessage = "order status code is a required field.")]
        public string? OrderStatusCode{ get; set;}


        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public RefOrderStatusCode? RefOrderStatusCode { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}
