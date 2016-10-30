using System;

namespace Verify.Exceptions
{
    internal class CollectionNotOfValidSize : Exception
    {
        public CollectionNotOfValidSize()
        {
        }

        public CollectionNotOfValidSize(string message) : base(message)
        {
        }

        public CollectionNotOfValidSize(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}