using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    public class ArrayFillOutFieldSizeExeption : Exception
    {
        public ArrayFillOutFieldSizeExeption() : base("Filling in the field was greater than the field.")
        {

        }
    }
}
