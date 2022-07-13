using System;

namespace OceanLogic
{
    public class ArrayFillOutFieldSizeExeption : Exception
    {
        public ArrayFillOutFieldSizeExeption()
        {
        }

        public ArrayFillOutFieldSizeExeption(string message) : base(message)
        {
        }

        public ArrayFillOutFieldSizeExeption(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
