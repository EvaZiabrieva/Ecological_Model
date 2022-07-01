using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Prey : Cell
    {
        public Prey(Random random) : base(random)
        {
        }

        public override char GetSymbol()
        {
            return 'F';
        }

        public override void Iterate(Cell[,] cells, int i, int j)
        {
            int direction = random.Next(0, 4);
            int offsetHorizontalMovement = 0;
            int offsetVerticalMovement = 0;

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
                    break;
            }

            if (IsMoveAccordingToLimit(cells, i, j, offsetHorizontalMovement, offsetVerticalMovement))
            {
                bool isEmptyNeghbour = cells[i + offsetHorizontalMovement, j + offsetVerticalMovement] == null;
                bool canEat = !isEmptyNeghbour && CanEat(cells[i + offsetHorizontalMovement, j + offsetVerticalMovement]);

                if (isEmptyNeghbour || canEat)
                {
                    cells[i + offsetHorizontalMovement, j + offsetVerticalMovement] = cells[i, j];
                    cells[i, j] = null;
                }
                if (canEat)
                    OnEat();
            }
        }

        public bool IsMoveAccordingToLimit(Cell[,] cells, int i, int j, int offsetI, int offsetJ)
        {
            return (j + offsetJ < cells.GetLength(1) && j + offsetJ >= 0
                && i + offsetI < cells.GetLength(0) && i + offsetI >= 0);
        }

        protected virtual bool CanEat(Cell cell)
        {
            return false;
        }

        protected virtual void OnEat()
        {
        }
    }
}
