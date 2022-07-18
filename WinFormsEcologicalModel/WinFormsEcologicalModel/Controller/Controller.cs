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
            for (int n = 1; n <= _iteretionsCount; n++)
            {
                int predatorCount = 0;
                int preyCount = 0;
                string oceanFill = "";

                Thread.Sleep(100);

                for (int i = 0; i < _ocean.GetWidth(); i++)
                {
                    for (int j = 0; j < _ocean.GetHeight(); j++)
                    {
                        oceanFill += Convert.ToString(_ocean.GetCellView(i, j));

                        if (_ocean.GetCellView(i, j) == OceanViewConst.PredatorSymbol)
                        {
                            predatorCount++;
                        }
                        else if (_ocean.GetCellView(i, j) == OceanViewConst.PreySymbol)
                        {
                            preyCount++;
                        }
                    }

                    oceanFill += "\n";
                }

                oceanFill += "Iteration:" + n  + "/" + _iteretionsCount + "\n" + "Predator count:" +
                    predatorCount + "\n" + "Prey count:" + preyCount + "\n";

                if(predatorCount == 0 || preyCount == 0 || n == _iteretionsCount)
                {
                    n = _iteretionsCount;

                    System.Windows.Forms.MessageBox.Show
                        ("**********\n" +
                        "Game Over!\n" +
                        "Tub 'Ok' to see final statistic\n" +
                        "**********");
                }

                _view.PrintField(oceanFill);
                _ocean.Iterate();
            }
        }
    }
}
