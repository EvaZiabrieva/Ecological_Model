using System;
using System.Threading;
using OceanLogic;

namespace WinFormsEcologicalModel
{
    class Controller : IController
    {
        private readonly IView _view;
        private readonly Ocean _ocean = new Ocean();
        private int _iteretionsCount;
        private bool _terminted;

        public Controller(IView view)
        {
            _view = view;
        }

        public string StartSimulation(int width, int height, int predatorCount, int preyCount,
            int obstacleCount, int iteretionsCount, int staticSuperPredator)
        {
            try
            {
                _ocean.Initilize(width, height);
                _ocean.ArrayFill(predatorCount, preyCount, obstacleCount, staticSuperPredator);
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

        public void Terminate()
        {
            _terminted = true;
        }

        private void OceanIteration()
        {
            CellData[,] oceanFill = new CellData[_ocean.GetWidth(), _ocean.GetHeight()];
            
            for (int n = 0; n < _iteretionsCount; n++)
            {
                Thread.Sleep(500);

                if (_terminted)
                {
                    return;
                }

                for (int i = 0; i < _ocean.GetWidth(); i++)
                {
                    for (int j = 0; j < _ocean.GetHeight(); j++)
                    {
                        oceanFill[i, j] = new CellData(_ocean[i, j] == null ? 0 : _ocean[i, j].GetHashCode(), _ocean.GetCellView(i, j));
                    }
                }

                _view.PrintField(oceanFill);
                _ocean.Iterate();
            }

            _view.NotifySimulationEnd();
        }
    }
}
