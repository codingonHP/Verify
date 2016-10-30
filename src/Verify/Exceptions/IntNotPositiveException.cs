using System;

namespace Verify
{
    internal class IntNotPositiveException : Exception
    {
        public IntNotPositiveException()
        {
        }

        public IntNotPositiveException(string message) : base(message)
        {
        }

        public IntNotPositiveException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}