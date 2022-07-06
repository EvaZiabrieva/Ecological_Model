using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    public class OceanRandom
    {
        private readonly Random random = new Random();
        private readonly IOceanView oceanView;

        public OceanRandom(IOceanView oceanView)
        {
            this.oceanView = oceanView;
        }

        public void GetEmptyCellPosition(out int i, out int j)
        {
            do
            {
                i = random.Next(0, oceanView.GetWidth());
                j = random.Next(0, oceanView.GetHeight());
            }
            while (oceanView.GetCellView(i, j) != '-');
        }

        public void GetOffset(out int offsetHorizontalMovement, out int offsetVerticalMovement)
        {
            int direction = random.Next(0, 4);

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
