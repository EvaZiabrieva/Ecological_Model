using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    abstract class Cell
    {
        protected readonly Random random;
        public Cell(Random random)
        {
            this.random = random;
        }
        public abstract char GetSymbol();
        public abstract void Iterate(Cell[,] cells, int i, int j);
    }
}
