using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EcologicalModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean();

            int width = 25;
            int height = 70;
            int predatorCount = 20;
            int preyCount = 150;
            int obstacleCount = 75;
            int iteretionsCount = 1000;

            Console.WriteLine("Use defult equals?" + "\nPress [Y] if yes." + "        " 
                + "Press any other button if no.");

            if(Console.ReadKey().KeyChar.ToString().ToUpper() != "Y")
            {
               ocean.UserEquals(out width, out height, out predatorCount, out preyCount, out obstacleCount, out iteretionsCount);
            }

            Console.Clear();

            ocean.Initilize(width, height);
            ocean.ArrayFill(predatorCount, preyCount, obstacleCount);
            ocean.FilledArrayOutput();
            ocean.CellsCountOutput();

            for (int i = 1; i <= iteretionsCount; i++) 
            {
                Thread.Sleep(500);
                ocean.Iterate();
                Console.Clear();
                ocean.FilledArrayOutput();
                Console.WriteLine("Iteretion: " + i);
                if (!ocean.CellsCountOutput())
                {
                    Console.WriteLine("**********"+"\nGame Over!"+ "\n**********");
                    break;
                }
                    
            }

            Console.ReadKey();
        }
    }
}
