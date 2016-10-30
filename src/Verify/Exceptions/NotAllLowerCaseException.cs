using System;

namespace VerifyContainer.Exceptions
{
    internal class NotAllLowerCaseException : Exception
    {
        public NotAllLowerCaseException()
        {
        }

        public NotAllLowerCaseException(string message) : base(message)
        {
        }

        public NotAllLowerCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}