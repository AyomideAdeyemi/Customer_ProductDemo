namespace Customer_ProductDemo.WebAPi.Exceptions
{
    public class IdParametersBadRequestException : BadRequestException
    {
        public IdParametersBadRequestException() : base("Parameter id is null")
        {
            
        }
    }
}
