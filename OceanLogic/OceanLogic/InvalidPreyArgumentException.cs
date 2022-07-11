using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidPreyArgumentException : ArgumentException
    {
        public InvalidPreyArgumentException() : base("Prey count could not be negative.")
        {
        }
    }
}
