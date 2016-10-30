using System;

namespace VerifyContainer.Exceptions
{
    internal class NotFalseException : Exception
    {
        public NotFalseException()
        {
        }

        public NotFalseException(string message) : base(message)
        {
        }

        public NotFalseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}