namespace OceanLogic
{
    class Prey : Cell
    {
        private int _reproduceCounter;
        private readonly int _maxTimeToReproduce = 6;

        public Prey(Ocean ocean) : base(ocean)
        {
            _reproduceCounter = _maxTimeToReproduce;
        }

        public override char GetSymbol()
        {
            return OceanViewConst.PreySymbol;
        }

        public override void Iterate(int i, int j)
        {
            _ocean.Random.GetOffset(out int offsetHorizontalMovement, out int offsetVerticalMovement);

            if (IsMoveAccordingToLimit(i, j, offsetHorizontalMovement, offsetVerticalMovement))
            {
                Cell neighbour = _ocean[i + offsetHorizontalMovement, j + offsetVerticalMovement];
                bool isEmptyNeghbour = neighbour == null;
                bool IscanEat = !isEmptyNeghbour && IsCanEat(neighbour);

                if (isEmptyNeghbour || IscanEat)
                {
                    _ocean[i + offsetHorizontalMovement, j + offsetVerticalMovement] = _ocean[i, j];

                    if (_reproduceCounter > 0)
                    {
                        _ocean[i, j] = null;
                        _reproduceCounter--;
                    }
                    else
                    {
                        _reproduceCounter = _maxTimeToReproduce;
                        _ocean[i, j] = CreteChild();
                    }
                }
                if (IscanEat)
                    Eat();
            }
        }

        protected virtual Cell CreteChild()
        {
            return new Prey(_ocean);
        }

        private bool IsMoveAccordingToLimit(int i, int j, int offsetI, int offsetJ)
        {
            return (j + offsetJ < _ocean.GetHeight() && j + offsetJ >= 0
                && i + offsetI < _ocean.GetWidth() && i + offsetI >= 0);
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
