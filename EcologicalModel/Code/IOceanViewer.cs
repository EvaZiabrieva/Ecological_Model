using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    interface IOceanViewer
    {
        void PrintOcean();
        void ClearPrint();
        void InputOceanParameters(ref int width, ref int height, ref int predatorCount, ref int preyCount,
           ref int obstacleCount, ref int iteretionsCount);
        bool CellsCountOutput(int iteretionIndex);
        void NotifyGameOver();
    }
}
