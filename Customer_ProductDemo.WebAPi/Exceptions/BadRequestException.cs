namespace Customer_ProductDemo.WebAPi.Exceptions
{
    public abstract class BadRequestException : Exception
    {
        protected BadRequestException(string message) : base(message){ }
    }
}
