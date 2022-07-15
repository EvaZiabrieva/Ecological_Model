using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEcologicalModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(LabelIteration);
            thread1.Start();
            label1.Font = new Font(FontFamily.GenericMonospace, 10);
        }
        private void LabelIteration()
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

                UpdateLabel(oceanFill);
                ocean.Iterate();
            }
        }
        private void UpdateLabel(string text)
        {
            if (label1.InvokeRequired)
            {
                label1.BeginInvoke((MethodInvoker)delegate () { label1.Text = text; });
            }
            else
            {
                label1.Text = text;
            }
        }
    }
}
