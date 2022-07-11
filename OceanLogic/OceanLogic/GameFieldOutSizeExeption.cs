using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class GameFieldOutSizeExeption : Exception
    {
        public GameFieldOutSizeExeption() : base("Invalid array size.")
        {

        }
    }
}
