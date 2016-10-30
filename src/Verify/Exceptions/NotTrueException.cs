using System;

namespace VerifyContainer.Exceptions
{
    internal class NotTrueException : Exception
    {
        public NotTrueException()
        {
        }

        public NotTrueException(string message) : base(message)
        {
        }

        public NotTrueException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}