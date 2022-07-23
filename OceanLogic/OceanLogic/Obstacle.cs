namespace OceanLogic
{
    class Obstacle : Cell
    {
        public Obstacle(Ocean ocean) : base(ocean)
        {
        }

        public override char GetSymbol()
        {
            return OceanViewConst.ObstacleSymbol;
        }

        public override void Iterate(int i, int j)
        {
        }
    }
}
