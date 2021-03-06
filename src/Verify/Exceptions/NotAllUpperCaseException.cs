﻿using System;

namespace VerifyContainer.Exceptions
{
    internal class NotAllUpperCaseException : Exception
    {
        public NotAllUpperCaseException()
        {
        }

        public NotAllUpperCaseException(string message) : base(message)
        {
        }

        public NotAllUpperCaseException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}