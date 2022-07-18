using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OceanLogic;

namespace WinFormsEcologicalModel
{
    class Controller : IController
    {
        private readonly IView _view;
        private readonly Ocean _ocean = new Ocean();
        private int _iteretionsCount;
        public Controller(IView view)
        {
            _view = view;
        }
        public string StartSimulation(int width, int height, int predatorCount, int preyCount,
            int obstacleCount, int iteretionsCount)
        {
            try
            {
                _ocean.Initilize(width, height);
                _ocean.ArrayFill(predatorCount, preyCount, obstacleCount);
                _iteretionsCount = iteretionsCount;

                Thread thread1 = new Thread(OceanIteration);
                thread1.Start();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void OceanIteration()
        {
            char[,] oceanFill = new char[_ocean.GetWidth(), _ocean.GetHeight()];

            for (int n = 0; n < _iteretionsCount; n++)
            {
                //string oceanFill = n + "\n";
                Thread.Sleep(100);

                for (int i = 0; i < _ocean.GetWidth(); i++)
                {
                    for (int j = 0; j < _ocean.GetHeight(); j++)
                    {
                        oceanFill[i, j] = _ocean.GetCellView(i, j);
                       // oceanFill += Convert.ToString(_ocean.GetCellView(i, j));
                    }
                    //oceanFill += "\n";
                }

                _view.PrintField(oceanFill);
                _ocean.Iterate();
            }
        }
    }
}
