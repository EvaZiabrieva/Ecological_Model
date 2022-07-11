using System;
using System.Collections.Generic;

namespace OceanLogic
{
    public class Ocean : IOceanView
    {
        private Cell[,] cells;
        private OceanRandom random;

        public OceanRandom Random
        {
            get
            {
                return random;
            }
        }

        public void Initilize(int maxRows, int maxCols)
        {
            if (maxRows <= 0 || maxCols <= 0)
                throw new GameFieldOutSizeExeption();
            cells = new Cell[maxRows, maxCols];
                random = new OceanRandom(this);
        }

        public void ArrayFill(int predatorsCount, int preysCount, int obstacleCount)
        {
            if (predatorsCount < 0)
                throw new InvalidPredatorArgumentException();
            if (preysCount < 0)
                throw new InvalidPreyArgumentException();
            if (obstacleCount < 0)
                throw new InvalidObstacleArgumentException();

            if (predatorsCount + preysCount + obstacleCount > cells.GetLength(0) * cells.GetLength(1))
            {
                throw new ArrayFillOutFieldSizeExeption();
            }

            for (int n = 0; n < predatorsCount; n++)
            {
                random.GetEmptyCellPosition(out int i, out int j);

                cells[i, j] = new Predator(this);
            }

            for (int n = 0; n < preysCount; n++)
            {
                random.GetEmptyCellPosition(out int i, out int j);

                cells[i, j] = new Prey(this);
            }

            for (int n = 0; n < obstacleCount; n++)
            {
                random.GetEmptyCellPosition(out int i, out int j);

                cells[i, j] = new Obstacle(this);
            }
        }

        public void Iterate()
        {
            HashSet<Cell> iteratedCells = new HashSet<Cell>();

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    Cell cell = cells[i, j];

                    if (cell != null && !iteratedCells.Contains(cell))
                    {
                        cell.Iterate(i, j);
                        iteratedCells.Add(cell);
                    }
                }
            }
        }

        public int GetWidth()
        {
            return cells.GetLength(0);
        }

        public int GetHeight()
        {
            return cells.GetLength(1);
        }

        public Cell this[int i, int j]
        {
            get
            {
                return cells[i, j];
            }

            set
            {
                if (i <= 0 || j <= 0 || i > GetWidth() || j > GetHeight()) 
                    throw new IndexOutOfRangeException();
                cells[i, j] = value;
            }
        }

        public char GetCellView(int i, int j)
        {
            if (i <= 0 || j <= 0 || i > GetWidth() || j > GetHeight())
                throw new IndexOutOfRangeException();
            if (this[i, j] == null)
            {
                return OceanViewConst.EmptyCellSymbol;
            }

            return this[i, j].GetSymbol();
        }
    }
}
