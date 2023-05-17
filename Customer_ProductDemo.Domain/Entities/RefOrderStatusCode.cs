using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Domain.Entities
{
    public class RefOrderStatusCode
    {
        [Key]
        public int OrderStatusCode { get; set; }
        public string? OrderStatusDescription { get; set; }

    }
}
