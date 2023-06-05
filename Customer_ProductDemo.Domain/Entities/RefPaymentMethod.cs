

using System.ComponentModel.DataAnnotations;

namespace Customer_ProductDemo.Domain.Entities
{
    public class RefPaymentMethod
    {
        [Key]
        public string? PaymentMethodeCode { get; set; }
        public string? PaymentMethodDescription { get; set; }

        public ICollection<Customer>? Customers { get; set; }
    }
}
