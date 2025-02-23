using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCalculator
{
    public partial class frmSimpleCalculator: Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // txtResult.Text = txtNumber1.Text + txtNumber2.Text; //this is concatenation
        
            txtResult.Text = (Convert.ToDouble(txtNumber1.Text) + Convert.ToDouble(txtNumber2.Text)).ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtNumber1.Text) - Convert.ToDouble(txtNumber2.Text)).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtNumber1.Text) * Convert.ToDouble(txtNumber2.Text)).ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Convert.ToDouble(txtNumber1.Text) % Convert.ToDouble(txtNumber2.Text)).ToString();
        }
    }
}
