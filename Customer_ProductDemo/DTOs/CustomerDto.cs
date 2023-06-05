using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs
{
    public class CustomerDto
    {
        
        public int CustomerId { get; set; }

        public string? PaymentMethodCode { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

       
        public string? Email { get; set; }
    }
}
