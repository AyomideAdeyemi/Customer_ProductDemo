using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Domain.Entities
{
    public class CustomerAddressHistory
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set;}

        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set;}

        [DataType(DataType.DateTime)]
        public DateTime DateTo { get; set;}

        [Required(ErrorMessage = " Address type code is a required field.")]
        public string? AddressTypeCode{ get; set; }
        
    }
}
