using System;

namespace VerifyContainer.Exceptions
{
    internal class CollectionContainsInvalidType : Exception
    {
        public CollectionContainsInvalidType()
        {
        }

        public CollectionContainsInvalidType(string message) : base(message)
        {
        }

        public CollectionContainsInvalidType(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}