﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_ProductDemo.Domain.Entities
{
    public class OrderItem
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

        public Product? Product { get; set; }

        //public CustomerOrder? CustomerOrder { get; set; }
    }
}
