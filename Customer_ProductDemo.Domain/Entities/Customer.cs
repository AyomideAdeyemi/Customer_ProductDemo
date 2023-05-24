using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Domain.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string? PaymentMethodCode { get; set; }

        [Required (ErrorMessage = "first name is a required field.")]
        [MaxLength (25, ErrorMessage = "first name is 25 character long.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "last name is a required field.")]
        [MaxLength(25, ErrorMessage = "last name is 25 character long.")]
        public string? LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [DataType (DataType.EmailAddress)]
        public string? Email { get; set; }


    }
}
