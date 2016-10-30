using System;

namespace VerifyContainer.Exceptions
{
    internal class StringAreNotEqualAsExpectedException : Exception
    {
        public StringAreNotEqualAsExpectedException()
        {
        }

        public StringAreNotEqualAsExpectedException(string message) : base(message)
        {
        }

        public StringAreNotEqualAsExpectedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}