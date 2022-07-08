namespace OceanLogic
{
    class Prey : Cell
    {
        private int reproduceCounter;
        private readonly int maxTimeToReproduce = 6;

        public Prey(Ocean ocean) : base(ocean)
        {
            reproduceCounter = maxTimeToReproduce;
        }

        public override char GetSymbol()
        {
            return OceanViewConst.PreySymbol;
        }

        public override void Iterate(int i, int j)
        {
            ocean.Random.GetOffset(out int offsetHorizontalMovement, out int offsetVerticalMovement);

            if (IsMoveAccordingToLimit(i, j, offsetHorizontalMovement, offsetVerticalMovement))
            {
                bool isEmptyNeghbour = ocean[i + offsetHorizontalMovement, j + offsetVerticalMovement] == null;
                bool IscanEat = !isEmptyNeghbour && IsCanEat(ocean[i + offsetHorizontalMovement, j + offsetVerticalMovement]);

                if (isEmptyNeghbour || IscanEat)
                {
                    ocean[i + offsetHorizontalMovement, j + offsetVerticalMovement] = ocean[i, j];

                    if (reproduceCounter > 0)
                    {
                        ocean[i, j] = null;
                        reproduceCounter--;
                    }
                    else
                    {
                        reproduceCounter = maxTimeToReproduce;
                        ocean[i, j] = CreteChild();
                    }
                }
                if (IscanEat)
                    Eat();
            }
        }

        protected virtual Cell CreteChild()
        {
            return new Prey(ocean);
        }

        private bool IsMoveAccordingToLimit(int i, int j, int offsetI, int offsetJ)
        {
            return (j + offsetJ < ocean.GetHeight() && j + offsetJ >= 0
                && i + offsetI < ocean.GetWidth() && i + offsetI >= 0);
        }


        protected virtual bool IsCanEat(Cell cell)
        {
            return false;
        }

        protected virtual void Eat()
        {
        }
    }
}
