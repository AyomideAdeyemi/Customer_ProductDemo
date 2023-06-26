using Customer_ProductDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_ProductDemo.Application.DTOs.Product
{
    public class ProductForCreation
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey(nameof(RefProductType))]
        public string? ProductTypeCode { get; set; }
        public string? ProductName { get; set; }
        public string? ProductPrice { get; set; }

       
    }
}
