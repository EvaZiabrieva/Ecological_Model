using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class ConsoleOceanViewer : IOceanViewer
    {
        private readonly IOceanView oceanView;

        public ConsoleOceanViewer(IOceanView oceanView)
        {
            this.oceanView = oceanView;
        }

        public void PrintOcean()
        {
            for (int i = 0; i < oceanView.GetWidth(); i++)
            {
               for (int j = 0; j < oceanView.GetHeight(); j++)
               {
                    Console.SetCursorPosition(j, i);
                    Console.Write(oceanView.GetCellView(i, j));
               }
            }

            Console.WriteLine();
        }

        public void NumExeption(out int value)
        {
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Not a number");
            }
        }
        public void InputOceanParameters(ref int width, ref int height, ref int predatorCount, ref int preyCount,
           ref int obstacleCount, ref int iteretionsCount)
        {
            Console.WriteLine("Use defult equals?" + "\nPress [Y] if yes." + "        "
                + "Press any other button if no.");

            if (Console.ReadKey().KeyChar.ToString().ToUpper() != "Y")
            {
                Console.WriteLine();
                Console.WriteLine("Width: ");
                NumExeption(out width);
                
                Console.WriteLine("Height: ");
                NumExeption(out height);

                Console.WriteLine("Predators count: ");
                NumExeption(out predatorCount);

                Console.WriteLine("Prey count: ");
                NumExeption(out preyCount);

                Console.WriteLine("Obstacle count: ");
                NumExeption(out obstacleCount);

                Console.WriteLine("Iteretions count: ");
                NumExeption(out iteretionsCount);
            }
            Console.Clear();
        }

        public bool CellsCountOutput(int iteretionIndex)
        {
            int predatorsCount = 0;
            int preysCount = 0;

            for (int i = 0; i < oceanView.GetWidth(); i++)
            {
                for (int j = 0; j < oceanView.GetHeight(); j++)
                {
                    if (oceanView.GetCellView(i, j) == OceanViewConst.PredatorSymbol)
                    {
                        predatorsCount++;
                    }
                    else if (oceanView.GetCellView(i, j) == OceanViewConst.PreySymbol)
                    {
                        preysCount++;
                    }
                }
            }

            Console.WriteLine("Predators: " + predatorsCount + "      ");
            Console.WriteLine("Prey: " + preysCount + "      ");
            Console.WriteLine("Iteretion: " + iteretionIndex + "      ");

            return preysCount > 0 && predatorsCount > 0;
        }

        public void NotifyGameOver()
        {
            Console.WriteLine(
                "**********\n" + 
                "Game Over!\n" + 
                "**********");
        }
    }
}
