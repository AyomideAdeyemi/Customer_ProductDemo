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
    public class CustomerOrderDto
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        
        public string? OrderStatusCode { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
