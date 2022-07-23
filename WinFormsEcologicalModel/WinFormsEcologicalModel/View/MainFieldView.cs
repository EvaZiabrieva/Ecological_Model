using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using OceanLogic;

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
        private Bitmap _staticSuperPredatorImage = new Bitmap(new Bitmap("Images/staticSuperPredator.png"), CELL_SIZE, CELL_SIZE);
        private int _preyCount;
        private int _predatorCount;
        private int _iterationCount;

        private Color _minColor = Color.FromArgb(0, 0, 128);
        private Color _maxColor = Color.FromArgb(128, 128, 255);

        public Form1()
        {
            InitializeComponent();
        }

        public void PrintField(CellData[,] field)
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

        private void CellsFill(CellData[,] field)
        {
            _iterationCount++;
            _predatorCount = 0;
            _preyCount = 0;

            if (!_isFieldInitilized)
            {
                FieldInit(field.GetLength(0), field.GetLength(1));
                _isFieldInitilized = true;
            }

            for (int i = 0; i < dataGridViewMainField.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMainField.ColumnCount; j++)
                {
                    dataGridViewMainField[j, i].Value = GetCellView(field[i, j].Symbol);
                    dataGridViewMainField[j, i].Style.BackColor = GetColor(field[i, j].Hash);
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

        private void FieldInit(int rowCount, int columnCount)
        {
            dataGridViewMainField.RowCount = rowCount;
            dataGridViewMainField.RowHeadersVisible = false;
            dataGridViewMainField.ColumnHeadersVisible = false;

            EnableDoubleBuffer();

            for (int i = 0; i < columnCount; i++)
            {
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Width = CELL_SIZE;
                dataGridViewMainField.Columns.Add(imageCol);

                if (i == 0)
                {
                    dataGridViewMainField.Columns.RemoveAt(0);
                }

                for (int j = 0; j < rowCount; j++)
                {
                    dataGridViewMainField.Rows[j].Height = CELL_SIZE;
                }
            }
        }

        private object GetCellView(char c)
        {
            switch (c)
            {
                case OceanViewConst.PredatorSymbol:
                    _predatorCount++;
                    return _predatorImage;
                case OceanViewConst.PreySymbol:
                    _preyCount++;
                    return _preyImage;
                case OceanViewConst.ObstacleSymbol:
                    return _obsticleImage;
                case OceanViewConst.StaticSuperPredatorSymbol:
                    return _staticSuperPredatorImage;
                default:
                    return _emptyImage;
            }
        }

        private Color GetColor(int hash)
        {
            byte[] bytes = BitConverter.GetBytes(hash);
            return Color.FromArgb(
                ModClamp(_minColor.R, _maxColor.R, bytes[0]),
                ModClamp(_minColor.G, _maxColor.G, bytes[1]),
                ModClamp(_minColor.B, _maxColor.B, bytes[2]));
        }

        private byte ModClamp(byte min, byte max, byte value)
        {
            return (byte)(value % (max - min + 1) + min);
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
            int staticSuperPredatorCount = Convert.ToInt32(txbStaticSuperPredator.Text);

            string error = _controller.StartSimulation(width, height, predatorCount, preyCount,
                    obstacleCount, iteretionsCount, staticSuperPredatorCount);

            if (error != null)
            {
                MessageBox.Show(error);
            }
            else
            {
                lblStatistic.Visible = true;
                dataGridViewMainField.Visible = true;

                btnChangeMaxColor.Visible = true;
                btnChangeMinColor.Visible = true;

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

                lblStaticSuperPredator.Visible = false;
                txbStaticSuperPredator.Visible = false;

                btnStartSimulation.Visible = false;
            }
        }

        public void SetController(IController controller)
        {
            _controller = controller;
        }

        private void btnChangeMinColor_Click(object sender, EventArgs e)
        {
            PickColor(ref _minColor);
        }

        private void btnChangeMaxColor_Click(object sender, EventArgs e)
        {
            PickColor(ref _maxColor);
        }

        private void PickColor(ref Color color)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowHelp = true;
            colorDialog.FullOpen = true;

            colorDialog.Color = color;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                color = colorDialog.Color;
        }
    }
}
