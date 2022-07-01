using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Predator : Prey
    {
        private int counter;
        private readonly int maxLifeIteretionCount = 6;

        public Predator(Random random) : base(random)
        {
            counter = maxLifeIteretionCount;
        }

        public override char GetSymbol()
        {
            return 'S';
        }

        public override void Iterate(Cell[,] cells, int i, int j)
        {
            if (counter > 0)
                base.Iterate(cells, i, j);
            else
                cells[i, j] = null;
            counter--;
        }

        protected override bool CanEat(Cell cell)
        {
            return cell.GetType() == typeof(Prey);
        }

        protected override void OnEat()
        {
            counter = maxLifeIteretionCount;
        }      
    }
}
