using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Obstacle: Cell
    {
        public Obstacle(Random random) : base(random)
        {
        }

        public override char GetSymbol()
        {
            return '#';
        }

        public override void Iterate(Cell[,] cells, int i, int j)
        {
        }
    }
}
 