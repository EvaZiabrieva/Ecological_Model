using System;
using System.Drawing;
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
            if (lblMainField.InvokeRequired)
            {
                lblMainField.BeginInvoke((MethodInvoker)delegate () { lblMainField.Text = field; });
            }
            else
            {
                lblMainField.Text = field;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMainField.Font = new Font(FontFamily.GenericMonospace, 10);
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txbWidth.Text);
            int height = Convert.ToInt32(txbHeight.Text);
            int predatorCount = Convert.ToInt32(txbPredatorCount.Text);
            int preyCount = Convert.ToInt32(txbPreyCount.Text);
            int obstacleCount = Convert.ToInt32(txbObstacleCount.Text);
            int iteretionsCount = Convert.ToInt32(txbIteretionsCount.Text);

            string error = _controller.StartSimulation(width, height, predatorCount, preyCount,
             obstacleCount, iteretionsCount);

            if (error != null)
            {
                MessageBox.Show(error);
            }
            else
            {
                lblMainField.Visible = true;

                lblWidth.Visible = false;
                txbWidth.Visible = false;

                lblHeight.Visible = false;
                txbHeight.Visible = false;

                lblPredatorCount.Visible = false;
                txbPredatorCount.Visible = false;

                lblPreyCount.Visible = false;
                txbPreyCount.Visible = false;

                lblObstacleCount.Visible = false;
                txbObstacleCount.Visible = false;

                lblIteretionsCount.Visible = false;
                txbIteretionsCount.Visible = false;

                btnStartSimulation.Visible = false;
            }
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }
    }
}
