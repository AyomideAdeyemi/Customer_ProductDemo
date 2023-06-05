namespace Customer_ProductDemo.WebAPi.Exceptions
{
    public sealed class CustomerNotFoundException : NotFoundException
    {
        public CustomerNotFoundException(string phoneNumber) 
            : base($"The Customer with phone {phoneNumber} doesn't exist in the database")
        {
            
        }
    }
}
