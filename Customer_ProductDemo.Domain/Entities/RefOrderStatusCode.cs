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
        public string? OrderStatusCode { get; set; }
        public string? Order_Status_Description { get; set; }

        public ICollection<RefOrderStatusCode>? RefOrderStatusCodes { get; set; }
    }
}
