﻿using System;

namespace VerifyContainer.Exceptions
{
    internal class ArgumentNotNullException : Exception
    {
        public ArgumentNotNullException()
        {
        }

        public ArgumentNotNullException(string message) : base(message)
        {
        }

        public ArgumentNotNullException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}