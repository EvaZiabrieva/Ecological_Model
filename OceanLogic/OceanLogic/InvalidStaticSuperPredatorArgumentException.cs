using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    class InvalidStaticSuperPredatorArgumentException : Exception
    {
        public InvalidStaticSuperPredatorArgumentException()
        {
        }

        public InvalidStaticSuperPredatorArgumentException(string message) : base(message)
        {
        }

        public InvalidStaticSuperPredatorArgumentException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
