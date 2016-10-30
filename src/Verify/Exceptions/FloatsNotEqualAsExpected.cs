using System;

namespace VerifyContainer.Exceptions
{
    internal class FloatsNotEqualAsExpected : Exception
    {
        public FloatsNotEqualAsExpected()
        {
        }

        public FloatsNotEqualAsExpected(string message) : base(message)
        {
        }

        public FloatsNotEqualAsExpected(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}