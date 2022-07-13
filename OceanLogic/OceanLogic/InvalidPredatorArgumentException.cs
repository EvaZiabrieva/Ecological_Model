using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidPredatorArgumentException : Exception
    {
        public InvalidPredatorArgumentException()
        {
        }

        public InvalidPredatorArgumentException(string message) : base(message)
        {
        }

        public InvalidPredatorArgumentException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
