using System.ComponentModel.DataAnnotations;


namespace Customer_ProductDemo.Domain.Entities
{
    public class OrderItem
    {
        [Key]
        public int OrderItenId { get; set; }
        public int OrderId { get; set; }
        public int ProudctId { get; set; }
        public int MyProperty { get; set; }
        public int OrderQuantity { get; set; }
       
    }
}
