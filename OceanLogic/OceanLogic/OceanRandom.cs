using System;

namespace OceanLogic
{
    public class OceanRandom
    {
        private readonly Random _random = new Random();
        private readonly IOceanView _oceanView;

        public OceanRandom(IOceanView oceanView)
        {
            this._oceanView = oceanView;
        }

        public void GetEmptyCellPosition(out int i, out int j)
        {
            do
            {
                i = _random.Next(0, _oceanView.GetWidth());
                j = _random.Next(0, _oceanView.GetHeight());
            }
            while (_oceanView.GetCellView(i, j) != '-');
        }

        public void GetOffset(out int offsetHorizontalMovement, out int offsetVerticalMovement)
        {
            int direction = _random.Next(0, 4);

            switch (direction)
            {
                case 0:
                    offsetHorizontalMovement = 1;
                    offsetVerticalMovement = 0;
                    break;
                case 1:
                    offsetHorizontalMovement = 0;
                    offsetVerticalMovement = 1;
                    break;
                case 2:
                    offsetHorizontalMovement = -1;
                    offsetVerticalMovement = 0;
                    break;
                case 3:
                    offsetHorizontalMovement = 0;
                    offsetVerticalMovement = -1;
                    break;
                default:
                    offsetHorizontalMovement = 0;
                    offsetVerticalMovement = 0;
                    break;
            }
        }
    }
}
