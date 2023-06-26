﻿using System;
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

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(RefOrderStatusCode))]
        public string? OrderStatusCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }


        public Customer? Customer { get; set; }
        public RefOrderStatusCode? RefOrderStatusCode { get; set; }

        public ICollection<OrderItem>? OrderItem { get; set; }

    }
}
