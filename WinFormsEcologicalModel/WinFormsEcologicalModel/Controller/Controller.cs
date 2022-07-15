using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WinFormsEcologicalModel
{
    class Controller : IController
    {
        private readonly IView _view;
        public Controller(IView view)
        {
            _view = view;
        }
        public void StartSimulation()
        {
            Thread thread1 = new Thread(OceanIteration);
            thread1.Start();
            _view.PrintField("abds");
        }

        private void OceanIteration()
        {
            OceanLogic.Ocean ocean = new OceanLogic.Ocean();

            ocean.Initilize(25, 70);
            ocean.ArrayFill(20, 30, 40);

            for (int n = 0; n < 100; n++)
            {
                string oceanFill = n + "\n";
                Thread.Sleep(100);

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 70; j++)
                    {
                        oceanFill += Convert.ToString(ocean.GetCellView(i, j));
                    }
                    oceanFill += "\n";
                }

                _view.PrintField(oceanFill);
                ocean.Iterate();
            }
        }
    }
}
