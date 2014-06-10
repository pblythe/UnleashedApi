using System;

namespace UnleashedApi.Exceptions
{
    public class InvalidRequestException : RequestException
    {
        public InvalidRequestException()
        {
        }

        public InvalidRequestException(string message) : base(message)
        {
        }

        public InvalidRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
