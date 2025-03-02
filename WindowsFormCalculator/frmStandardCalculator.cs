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
            txtResult.Text = new DataTable().Compute(txtFormula.Text, null).ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "3";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtFormula.Text += "*";
        }
    }
}
