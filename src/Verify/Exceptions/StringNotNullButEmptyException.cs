using System;

namespace VerifyContainer.Exceptions
{
    internal class StringNotNullButEmptyException : Exception
    {
        public StringNotNullButEmptyException()
        {
        }

        public StringNotNullButEmptyException(string message) : base(message)
        {
        }

        public StringNotNullButEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}