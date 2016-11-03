using System;
using System.Runtime.Serialization;

namespace VerifyContainer
{
    [Serializable]
    internal class CollectionMismatchException : Exception
    {
        public CollectionMismatchException()
        {
        }

        public CollectionMismatchException(string message) : base(message)
        {
        }

        public CollectionMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CollectionMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}