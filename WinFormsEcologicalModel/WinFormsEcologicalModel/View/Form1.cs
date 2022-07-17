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
    public partial class Form1 : Form, IView
    {
        private IController _controller;
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintField(string field)
        {
            if (label1.InvokeRequired)
            {
                label1.BeginInvoke((MethodInvoker)delegate () { label1.Text = field; });
            }
            else
            {
                label1.Text = field;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(FontFamily.GenericMonospace, 10);
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthTextBox.Text);
            int height = Convert.ToInt32(heightTextBox.Text);
            int predatorCount = Convert.ToInt32(predatorCountTextBox.Text);
            int preyCount = Convert.ToInt32(preyCountTextBox.Text);
            int obstacleCount = Convert.ToInt32(obstacleCountTextBox.Text);
            int iteretionsCount = Convert.ToInt32(iteretionsCountTextBox.Text);

            string error = _controller.StartSimulation(width, height, predatorCount, preyCount,
             obstacleCount, iteretionsCount);

            if (error != null)
            {
                MessageBox.Show(error);
            }
            else
            {
                label1.Visible = true;
                widthLabel.Visible = false;
                widthTextBox.Visible = false;

                heightLabel.Visible = false;
                heightTextBox.Visible = false;

                predatorCountLabel.Visible = false;
                predatorCountTextBox.Visible = false;

                preyCountLabel.Visible = false;
                preyCountTextBox.Visible = false;

                obstacleCountLabel.Visible = false;
                obstacleCountTextBox.Visible = false;

                iteretionsCountLabel.Visible = false;
                iteretionsCountTextBox.Visible = false;

                startSimulationButton.Visible = false;
            }
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }
    }
}
