using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Application.Exceptions
{
    public class BusinessLogicException : Exception
    {
        public BusinessLogicException(string message) : base(message)
        {

        }
    }
}
