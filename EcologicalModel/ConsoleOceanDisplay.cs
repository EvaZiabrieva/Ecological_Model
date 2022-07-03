using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class ConsoleOceanDisplay : IOceanDisplay
    {
        private readonly Ocean ocean;
        public ConsoleOceanDisplay(Ocean ocean)
        {
            this.ocean = ocean;
        }
        public void PrintOcean()
        {
            for (int i = 0; i < ocean.GetWidth(); i++)
            {
               string line = "";
       
               for (int j = 0; j < ocean.GetHeight(); j++)
               {
                   if (ocean.GetCell(i, j) != null)
                       line += ocean.GetCell(i, j).GetSymbol();
                   else
                       line += "-";
               }
       
               Console.WriteLine(line);
            }
        }
        public void ClearPrint()
        {
            Console.Clear();
        }

        public void InputOceanParameters(ref int width, ref int height, ref int predatorCount, ref int preyCount,
           ref int obstacleCount, ref int iteretionsCount)
        {
            Console.WriteLine("Use defult equals?" + "\nPress [Y] if yes." + "        "
                + "Press any other button if no.");

            if (Console.ReadKey().KeyChar.ToString().ToUpper() != "Y")
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

        }

        public bool CellsCountOutput(int iteretionIndex)
        {
            int predatorsCount = 0;
            int preysCount = 0;
            int obsecleCount = 0;

            for (int i = 0; i < ocean.GetWidth(); i++)
            {
                for (int j = 0; j < ocean.GetHeight(); j++)
                {
                    if (ocean.GetCell(i, j) is Predator)
                    {
                        predatorsCount++;
                    }
                    else if (ocean.GetCell(i, j) is Prey)
                    {
                        preysCount++;
                    }
                    else if (ocean.GetCell(i, j) is Obstacle)
                    {
                        obsecleCount++;
                    }
                }
            }

            Console.WriteLine("Predators: " + predatorsCount);
            Console.WriteLine("Prey: " + preysCount);
            Console.WriteLine("Obstacle: " + obsecleCount);
            Console.WriteLine("Iteretion: " + iteretionIndex);

            return preysCount > 0 && predatorsCount > 0;
        }

        public void NotifyGameOver()
        {
            Console.WriteLine("**********" + "\nGame Over!" + "\n**********");
        }
    }
}
