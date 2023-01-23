using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtsalary.Clear();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtid.Text+txtname.Text+txtsalary.Text);
        }
    }
}
