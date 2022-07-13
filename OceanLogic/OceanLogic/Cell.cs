namespace OceanLogic
{
    public abstract class Cell
    {
        protected readonly Ocean _ocean;

        public Cell(Ocean ocean)
        {
            this._ocean = ocean;
        }

        public abstract char GetSymbol();
        public abstract void Iterate(int i, int j);

    }
}
