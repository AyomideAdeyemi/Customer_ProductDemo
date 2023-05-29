namespace Customer_ProductDemo.WebAPi.Exceptions
{
    public abstract class NotFoundException : Exception
    {
        protected NotFoundException(string message): base(message){ }
    }
}
