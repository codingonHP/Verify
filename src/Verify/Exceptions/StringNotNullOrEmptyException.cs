﻿using System;

namespace VerifyContainer.Exceptions
{
    internal class StringNotNullOrEmptyException : Exception
    {
        public StringNotNullOrEmptyException()
        {
        }

        public StringNotNullOrEmptyException(string message) : base(message)
        {
        }

        public StringNotNullOrEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}