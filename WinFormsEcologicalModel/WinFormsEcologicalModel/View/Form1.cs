using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsEcologicalModel
{
    public partial class Form1 : Form, IView
    {
        private IController _controller;
        private bool _isFieldInitilized;
        public Form1()
        {
            InitializeComponent();
        }

        public void PrintField(char[,] field)
        {
            if (dataGridViewMainField.InvokeRequired)
            {
                dataGridViewMainField.BeginInvoke((MethodInvoker)delegate () { CellsFill(field); });
            }
            else
            {
                CellsFill(field);
            }
        }

        private void CellsFill(char[,] field)
        {
            if (_isFieldInitilized == false)
            {
                dataGridViewMainField.RowCount = field.GetLength(0);
                dataGridViewMainField.ColumnCount = field.GetLength(1);

                dataGridViewMainField.RowHeadersVisible = false;
                dataGridViewMainField.ColumnHeadersVisible = false;


                for (int i = 0; i < field.GetLength(0); i++)
                {
                    dataGridViewMainField.Rows[i].Height = 15;
                   
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        dataGridViewMainField.Columns[j].Width = 15;
                        dataGridViewMainField.Columns[j].DefaultCellStyle.Font = 
                            new Font(FontFamily.GenericMonospace, 10);
                    }
                }
                _isFieldInitilized = true;
            }

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    dataGridViewMainField[j, i].Value = field[i, j];
                }
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
                dataGridViewMainField.Visible = true;

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
