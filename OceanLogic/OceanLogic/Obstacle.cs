namespace OceanLogic
{
    class Obstacle : Cell
    {
        public Obstacle(Ocean ocean) : base(ocean)
        {
        }

        public override char GetSymbol()
        {
            return OceanViewConst._obstacleSymbol;
        }

        public override void Iterate(int i, int j)
        {
        }
    }
}
