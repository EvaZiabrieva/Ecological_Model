using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    public class Ocean
    {
        private Cell[,] cells;
        Random random = new Random();

        public void Initilize(int maxRows, int maxCols)
        {
            cells = new Cell[maxRows, maxCols];
        }

        public void ArrayFill(int predatorsCount, int preysCount, int obstacleCount)
        {
            if (predatorsCount + preysCount + obstacleCount > cells.GetLength(0) * cells.GetLength(1))
            {
                return;
            }

            for (int n = 0; n < predatorsCount; n++)
            {
                int i;
                int j;

                do
                {
                    i = random.Next(0, cells.GetLength(0));
                    j = random.Next(0, cells.GetLength(1));
                }
                while (cells[i, j] != null);

                cells[i, j] = new Predator(random, this);
            }

            for (int n = 0; n < preysCount; n++)
            {
                int i;
                int j;

                do
                {
                    i = random.Next(0, cells.GetLength(0));
                    j = random.Next(0, cells.GetLength(1));
                }
                while (cells[i, j] != null);

                cells[i, j] = new Prey(random, this);
            }

            for (int n = 0; n < obstacleCount; n++)
            {
                int i;
                int j;

                do
                {
                    i = random.Next(0, cells.GetLength(0));
                    j = random.Next(0, cells.GetLength(1));
                }
                while (cells[i, j] != null);

                cells[i, j] = new Obstacle(random, this);
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

        public Cell GetCell(int i, int j)
        {
            return cells[i, j];
        }

        public void SetCell(int i, int j, Cell cell)
        {
            cells[i, j] = cell;
        }
    }
}
