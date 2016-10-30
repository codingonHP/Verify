using System;

namespace Verify.Exceptions
{
    internal class IntAreNotEqualAsExpectedException : Exception
    {
        public IntAreNotEqualAsExpectedException()
        {
        }

        public IntAreNotEqualAsExpectedException(string message) : base(message)
        {
        }

        public IntAreNotEqualAsExpectedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}