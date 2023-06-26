using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.Customer
{
    public class CustomerForUpdateDto
    {
        [Key]
        public int CustomerId { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
