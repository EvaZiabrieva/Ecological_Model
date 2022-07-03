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
            IOceanDisplay oceanDisplay = new ConsoleOceanDisplay(ocean);

            int width = 25;
            int height = 70;
            int predatorCount = 20;
            int preyCount = 150;
            int obstacleCount = 75;
            int iteretionsCount = 1000;

            oceanDisplay.InputOceanParameters(ref width, ref height, ref predatorCount, ref preyCount, ref obstacleCount,
                    ref iteretionsCount);

            oceanDisplay.ClearPrint();

            ocean.Initilize(width, height);
            ocean.ArrayFill(predatorCount, preyCount, obstacleCount);
            oceanDisplay.PrintOcean();
            oceanDisplay.CellsCountOutput(0);

            for (int i = 1; i <= iteretionsCount; i++) 
            {
                Thread.Sleep(500);
                ocean.Iterate();
                oceanDisplay.ClearPrint();
                oceanDisplay.PrintOcean();
                
                if (!oceanDisplay.CellsCountOutput(i))
                {
                    oceanDisplay.NotifyGameOver();
                    break;
                }
                    
            }

            Console.ReadKey();
        }
    }
}
