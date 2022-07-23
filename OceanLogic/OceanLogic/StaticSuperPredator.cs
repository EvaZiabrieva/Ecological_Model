using System;
using System.Collections.Generic;
using System.Text;

namespace OceanLogic
{
    class StaticSuperPredator : Cell
    {
        public StaticSuperPredator(Ocean ocean) : base(ocean)
        {
        }

        public override char GetSymbol()
        {
            return OceanViewConst.StaticSuperPredatorSymbol;
        }

        public override void Iterate(int i, int j)
        {
            _ocean.Random.GetOffset(out int offsetHorizontal, out int offsetVertical);

            if (IsInLimits(i, j, offsetHorizontal, offsetVertical))
            {
                Cell neighbour = _ocean[i + offsetHorizontal, j + offsetVertical];
                if (neighbour is Prey)
                {
                    _ocean[i + offsetHorizontal, j + offsetVertical] = null;
                }
            }
        }

        private bool IsInLimits(int i, int j, int offsetI, int offsetJ)
        {
            return (j + offsetJ < _ocean.GetHeight() && j + offsetJ >= 0
                && i + offsetI < _ocean.GetWidth() && i + offsetI >= 0);
        }
    }
}
