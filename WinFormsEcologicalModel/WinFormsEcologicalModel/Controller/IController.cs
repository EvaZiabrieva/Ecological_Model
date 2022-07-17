using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsEcologicalModel
{
    public interface IController
    {
        string StartSimulation(int width, int height, int predatorCount, int preyCount,
            int obstacleCount, int iteretionsCount);
    }
}
