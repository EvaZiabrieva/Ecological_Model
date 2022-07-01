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

        public void UserEquals(out int width, out int height, out int predatorCount, out int preyCount,
            out int obstacleCount, out int iteretionsCount)
        {
                Console.WriteLine("\nWidth: ");
                width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Height: ");
                height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Predators count: ");
                predatorCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Prey count: ");
                preyCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Obstacle count: ");
                obstacleCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Iteretions count: ");
                iteretionsCount = Convert.ToInt32(Console.ReadLine());

        }

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

                cells[i, j] = new Predator(random);
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

                cells[i, j] = new Prey(random);
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

                cells[i, j] = new Obstacle(random);
            }
        }

        public void FilledArrayOutput()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                string line = "";

                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j] != null)
                        line += cells [i, j].GetSymbol();
                    else
                        line += "-";
                }

                Console.WriteLine(line);
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
                        cell.Iterate(cells, i, j);
                        iteratedCells.Add(cell);
                    }
                }
            }
        }

        public void CellsCountOutput()
        {
            int predatorsCount = 0;
            int preysCount = 0;
            int obsecleCount = 0;

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i,j] is Predator)
                    {
                        predatorsCount++;
                    }
                    else if (cells[i, j] is Prey)
                    {
                        preysCount++;
                    }
                    else if (cells[i, j] is Obstacle)
                    {
                        obsecleCount++;
                    }
                }
            }

            Console.WriteLine("Predators: " + predatorsCount);
            Console.WriteLine("Prey: " + preysCount);
            Console.WriteLine("Obstacle: " + obsecleCount);
        }
    }
}
