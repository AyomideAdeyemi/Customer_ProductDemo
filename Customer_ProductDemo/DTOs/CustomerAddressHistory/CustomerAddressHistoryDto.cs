using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.CustomerAddressHistory
{
    public class CustomerAddressHistoryDto
    {
        
        public int CustomerId { get; set; }

        public int AddressId { get; set; }

        
        public DateTime DateFrom { get; set; }

    
        public DateTime DateTo { get; set; }

        public string? AddressTypeCode { get; set; }

        
    }
}
