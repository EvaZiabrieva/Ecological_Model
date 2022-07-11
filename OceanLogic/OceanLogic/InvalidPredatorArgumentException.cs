using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidPredatorArgumentException : ArgumentException
    {
        public InvalidPredatorArgumentException() : base("Predator count could not be negative.")
        {

        }
    }
}
