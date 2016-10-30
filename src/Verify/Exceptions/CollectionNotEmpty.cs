using System;

namespace VerifyContainer.Exceptions
{
    internal class CollectionNotEmpty : Exception
    {
        public CollectionNotEmpty()
        {
        }

        public CollectionNotEmpty(string message) : base(message)
        {
        }

        public CollectionNotEmpty(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}