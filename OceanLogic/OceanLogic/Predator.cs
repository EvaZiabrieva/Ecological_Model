namespace OceanLogic
{
    class Predator : Prey
    {
        private int lifeTimeCounter;
        private readonly int maxLifeIteretionCount = 6;

        public Predator(Ocean ocean) : base(ocean)
        {
            lifeTimeCounter = maxLifeIteretionCount;
        }

        public override char GetSymbol()
        {
            return OceanViewConst.PredatorSymbol;
        }

        public override void Iterate(int i, int j)
        {
            if (lifeTimeCounter > 0)
            {
                base.Iterate(i, j);
            }
            else
            {
                ocean[i, j] = null;
            }

            lifeTimeCounter--;
        }

        protected override bool IsCanEat(Cell cell)
        {
            return cell.GetType() == typeof(Prey);
        }

        protected override void Eat()
        {
            lifeTimeCounter = maxLifeIteretionCount;
        }

        protected override Cell CreteChild()
        {
            return new Predator(ocean);
        }
    }
}
