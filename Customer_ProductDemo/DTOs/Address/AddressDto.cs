using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.Address
{
    public class AddressDto
    {
        public int AddressId { get; set; }

        public string? BuildingNumber { get; set; }

        public string? StreetName { get; set; }

        public string? ArearLocality { get; set; }

        public string? State { get; set; }

    }
}
