namespace NerdStore.Core.DomainObjects
{
    //importante para quando for feito o tratamento das exceptions, saiba que seria um problema expecifico
    public class DomainException : Exception
    {
        public DomainException()
        {

        }

        public DomainException(string message) : base(message)
        {
            
        }

        public DomainException(string message, Exception innerException) : base(message, innerException) 
        {
            
        }
    }
}
