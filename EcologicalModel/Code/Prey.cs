using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Prey : Cell
    {
        private int reproduceCounter;
        private readonly int maxTimeToReproduce = 6;

        public Prey(Random random, Ocean ocean) : base(random, ocean)
        {
            reproduceCounter = maxTimeToReproduce;
        }

        public override char GetSymbol()
        {
            return 'f';
        }

        public override void Iterate(int i, int j)
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

            if (IsMoveAccordingToLimit( i, j, offsetHorizontalMovement, offsetVerticalMovement))
            {
                bool isEmptyNeghbour = ocean.GetCell(i + offsetHorizontalMovement, j + offsetVerticalMovement) == null;
                bool canEat = !isEmptyNeghbour && CanEat(ocean.GetCell(i + offsetHorizontalMovement, j + offsetVerticalMovement));

                if (isEmptyNeghbour || canEat)
                {
                    ocean.SetCell(i + offsetHorizontalMovement, j + offsetVerticalMovement, ocean.GetCell(i, j));
                    if(reproduceCounter > 0)
                    {
                        ocean.SetCell(i, j, null);
                        reproduceCounter--;
                    }
                    else 
                    {
                        reproduceCounter = maxTimeToReproduce;
                        ocean.SetCell(i, j, CreteChild());
                    }
                }
                if (canEat)
                    OnEat();
            }
        }

        protected virtual Cell CreteChild()
        {
            return new Prey(random, ocean);
        }

        public bool IsMoveAccordingToLimit(int i, int j, int offsetI, int offsetJ)
        {
            return (j + offsetJ < ocean.GetHeight() && j + offsetJ >= 0
                && i + offsetI < ocean.GetWidth() && i + offsetI >= 0);
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
