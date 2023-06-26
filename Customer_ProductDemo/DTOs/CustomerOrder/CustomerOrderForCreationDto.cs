using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.CustomerOrder
{
    internal class CustomerOrderForCreationDto
    {

        [Key]
        public int OrderId { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(RefOrderStatusCode))]
        public string? OrderStatusCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}
