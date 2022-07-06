using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Obstacle: Cell
    {
        public Obstacle(Ocean ocean) : base(ocean)
        {
        }

        public override char GetSymbol()
        {
            return OceanViewConst.ObstacleSymbol;
        }

        public override void Iterate(int i, int j)
        {
        }
    }
}
 