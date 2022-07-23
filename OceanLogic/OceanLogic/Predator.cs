namespace OceanLogic
{
    class Predator : Prey
    {
        private int _lifeTimeCounter;
        private readonly int _maxLifeIteretionCount = 6;

        public Predator(Ocean ocean) : base(ocean)
        {
            _lifeTimeCounter = _maxLifeIteretionCount;
        }

        public override char GetSymbol()
        {
            return OceanViewConst.PredatorSymbol;
        }

        public override void Iterate(int i, int j)
        {
            if (_lifeTimeCounter > 0)
            {
                base.Iterate(i, j);
            }
            else
            {
                _ocean[i, j] = null;
            }

            _lifeTimeCounter--;
        }

        protected override bool IsCanEat(Cell cell)
        {
            return cell.GetType() == typeof(Prey);
        }

        protected override void Eat()
        {
            _lifeTimeCounter = _maxLifeIteretionCount;
        }

        protected override Cell CreteChild()
        {
            return new Predator(_ocean);
        }
    }
}
