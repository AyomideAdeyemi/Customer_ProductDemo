using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Domain.Entities
{
    public class RefAddressType
    {
        [Key]
        public string? AddressTypeCode { get; set; }

        [Required(ErrorMessage = "Address is a required field.")]
        [MaxLength(100)]
        public string? Address { get; set; }

    }
}
