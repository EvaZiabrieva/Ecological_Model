using System;
using System.Collections.Generic;

namespace OceanLogic
{
    public class Ocean : IOceanView
    {
        private Cell[,] _cells;
        private readonly OceanRandom _random;

        public Ocean()
        {
            _random = new OceanRandom(this);
        }

        public OceanRandom Random
        {
            get
            {
                return _random;
            }
        }

        public void Initilize(int maxRows, int maxCols)
        {
            if (maxRows <= 0 || maxCols <= 0)
            {
                throw new GameFieldOutSizeExeption("Invalid array size.");
            }
                
            _cells = new Cell[maxRows, maxCols];
            
        }

        public void ArrayFill(int predatorsCount, int preysCount, int obstacleCount, 
            int staticSuperPredatorCount)
        {
            if (predatorsCount < 0)
            {
                throw new InvalidPredatorArgumentException("Predator count could not be negative.");
            }
                
            if (preysCount < 0)
            {
                throw new InvalidPreyArgumentException("Prey count could not be negative.");
            }
                
            if (obstacleCount < 0)
            {
                throw new InvalidObstacleArgumentException("Obstacle count could not be negative.");
            }

            if (staticSuperPredatorCount < 0)
            {
                throw new InvalidStaticSuperPredatorArgumentException("Static super predator count could not be negative.");
            }
            int targetFillCellsCount = predatorsCount + preysCount + obstacleCount + staticSuperPredatorCount;
            int availableCellsCount = _cells.GetLength(0) * _cells.GetLength(1);

            if (targetFillCellsCount > availableCellsCount)
            {
                throw new ArrayFillOutFieldSizeExeption("Filling in the field was greater than the field.");
            }

            for (int n = 0; n < predatorsCount; n++)
            {
                _random.GetEmptyCellPosition(out int i, out int j);

                _cells[i, j] = new Predator(this);
            }

            for (int n = 0; n < preysCount; n++)
            {
                _random.GetEmptyCellPosition(out int i, out int j);

                _cells[i, j] = new Prey(this);
            }

            for (int n = 0; n < obstacleCount; n++)
            {
                _random.GetEmptyCellPosition(out int i, out int j);

                _cells[i, j] = new Obstacle(this);
            }

            for (int n = 0; n < staticSuperPredatorCount; n++)
            {
                _random.GetEmptyCellPosition(out int i, out int j);

                _cells[i, j] = new StaticSuperPredator(this);
            }
        }

        public void Iterate()
        {
            HashSet<Cell> iteratedCells = new HashSet<Cell>();

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    Cell cell = _cells[i, j];

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
            return _cells.GetLength(0);
        }

        public int GetHeight()
        {
            return _cells.GetLength(1);
        }

        public Cell this[int i, int j]
        {
            get
            {
                return _cells[i, j];
            }

            set
            {
                SetCell(i, j, value);
            }
        }

        private void SetCell(int i, int j, Cell value)
        {
            if (i < 0 || j < 0 || i > GetWidth() - 1 || j > GetHeight() - 1)
            {
                throw new IndexOutOfRangeException("Cell position was out of range.");
            }

            _cells[i, j] = value;
        }

        public char GetCellView(int i, int j)
        {
            if (i < 0 || j < 0 || i > GetWidth() - 1 || j > GetHeight() - 1)
            {
                throw new IndexOutOfRangeException("Cell position was out of range.");
            }
                
            if (this[i, j] == null)
            {
                return OceanViewConst.EmptyCellSymbol;
            }

            return this[i, j].GetSymbol();
        }
    }
}
