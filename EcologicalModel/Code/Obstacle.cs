using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Obstacle: Cell
    {
        public Obstacle(Random random, Ocean ocean) : base(random, ocean)
        {
        }

        public override char GetSymbol()
        {
            return '#';
        }

        public override void Iterate(int i, int j)
        {
        }
    }
}
 