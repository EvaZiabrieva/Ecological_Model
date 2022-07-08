namespace OceanLogic
{
    public abstract class Cell
    {
        protected readonly Ocean ocean;

        public Cell(Ocean ocean)
        {
            this.ocean = ocean;
        }

        public abstract char GetSymbol();
        public abstract void Iterate(int i, int j);

    }
}
