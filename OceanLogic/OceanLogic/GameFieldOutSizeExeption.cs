using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class GameFieldOutSizeExeption : Exception
    {
        public GameFieldOutSizeExeption()
        {
        }

        public GameFieldOutSizeExeption(string message) : base(message)
        {
        }

        public GameFieldOutSizeExeption(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
