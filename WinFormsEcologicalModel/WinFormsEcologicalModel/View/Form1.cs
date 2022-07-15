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
       
    }
}
