using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidPreyArgumentException : Exception
    {
        public InvalidPreyArgumentException()
        {
        }

        public InvalidPreyArgumentException(string message) : base(message)
        {
        }

        public InvalidPreyArgumentException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
