using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormsEcologicalModel
{
    public partial class Form1 : Form, IView
    {
        private const int CELL_SIZE = 25; 
        private IController _controller;
        private bool _isFieldInitilized;
        private Bitmap _preyImage = new Bitmap(new Bitmap("Images/prey.png"), CELL_SIZE, CELL_SIZE);
        private Bitmap _predatorImage = new Bitmap(new Bitmap("Images/predator.png"), CELL_SIZE, CELL_SIZE);
        private Bitmap _obsticleImage = new Bitmap(new Bitmap("Images/obsticle.png"), CELL_SIZE, CELL_SIZE);
        private Bitmap _emptyImage = new Bitmap(new Bitmap("Images/empty.png"), CELL_SIZE, CELL_SIZE);
        private int _preyCount;
        private int _predatorCount;
        private int _iterationCount;

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
            _iterationCount++;
            _predatorCount = 0;
            _preyCount = 0;

            if (!_isFieldInitilized)
            {
                FieldInit(field);
                _isFieldInitilized = true;
            }

            for (int i = 0; i < dataGridViewMainField.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMainField.ColumnCount; j++)
                {
                    dataGridViewMainField[j, i].Value = GetCellView(field[i, j]);
                }
            }

            lblStatistic.Text = "Prey: " + _preyCount +
                "\nPredator: " + _predatorCount +
                "\nIteration: " + _iterationCount;

            if (_preyCount == 0 || _predatorCount == 0)
            {
                _controller.Terminate();
                NotifySimulationEnd();
            }
               
        }

        public void NotifySimulationEnd()
        {
            MessageBox.Show("Simulation is over!");
        }

        private void FieldInit(char[,] field)
        {
            dataGridViewMainField.RowCount = field.GetLength(0);

            dataGridViewMainField.RowHeadersVisible = false;
            dataGridViewMainField.ColumnHeadersVisible = false;
            EnableDoubleBuffer();


            for (int i = 0; i < field.GetLength(1); i++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = CELL_SIZE;
                dataGridViewMainField.Columns.Add(imageCol);

                if (i == 0)
                {
                    dataGridViewMainField.Columns.RemoveAt(0);
                }

                for (int j = 0; j < field.GetLength(0); j++)
                {
                    dataGridViewMainField.Rows[j].Height = CELL_SIZE;
                }
            }
        }

        private object GetCellView(char c)
        {
            switch (c)
            {
                case 'S':
                    _predatorCount++;
                    return _predatorImage;
                case 'f':
                    _preyCount++;
                    return _preyImage;
                case '#':
                    return _obsticleImage;
                default:
                    return _emptyImage;
            }
        }

        private void EnableDoubleBuffer()
        {
            typeof(DataGridView)
                .InvokeMember(
                    "DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, dataGridViewMainField, new object[] { true });
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
                lblStatistic.Visible = true;
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
