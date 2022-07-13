using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidObstacleArgumentException : Exception
    {
        public InvalidObstacleArgumentException()
        {
        }

        public InvalidObstacleArgumentException(string message) : base(message)
        {
        }

        public InvalidObstacleArgumentException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
