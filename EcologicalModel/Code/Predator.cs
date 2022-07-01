using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Predator : Prey
    {
        private int lifeTimeCounter;
        private readonly int maxLifeIteretionCount = 6;

        public Predator(Random random) : base(random)
        {
            lifeTimeCounter = maxLifeIteretionCount;
        }

        public override char GetSymbol()
        {
            return 'S';
        }

        public override void Iterate(Cell[,] cells, int i, int j)
        {
            if (lifeTimeCounter > 0)
                base.Iterate(cells, i, j);
            else
                cells[i, j] = null;
            lifeTimeCounter--;
        }

        protected override bool CanEat(Cell cell)
        {
            return cell.GetType() == typeof(Prey);
        }

        protected override void OnEat()
        {
            lifeTimeCounter = maxLifeIteretionCount;
        }

        protected override Cell CreteChild()
        {
            return new Predator(random);
        }
    }
}
