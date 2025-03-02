using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Data;


namespace WindowsFormCalculator
{
    public partial class frmSatndardCalculator : Form
    {
        public frmSatndardCalculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "7";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtFormula.Text = new DataTable().Compute(txtFormula.Text, null).ToString();
        }
    }
}
