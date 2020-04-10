﻿using System;

namespace CQRS.Application.Configuration.Processing.Validation
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException(string message) : base(message)
        {
        }
    }
}
