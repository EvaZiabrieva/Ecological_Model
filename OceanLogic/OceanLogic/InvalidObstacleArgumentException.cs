using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class InvalidObstacleArgumentException : ArgumentException
    {
        public InvalidObstacleArgumentException() : base("Obstacle count could not be negative.")
        {
        }
    }
}
