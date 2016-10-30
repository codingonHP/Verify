using System;

namespace Verify
{
    internal class IntNotNegativeException : Exception
    {
        public IntNotNegativeException()
        {
        }

        public IntNotNegativeException(string message) : base(message)
        {
        }

        public IntNotNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}