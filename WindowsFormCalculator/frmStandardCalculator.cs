﻿using System.Windows.Forms;
using System;
using System.Data;


namespace WindowsFormCalculator
{
   
    public partial class frmSatndardCalculator : Form
    {
      public bool isEqualCliked = false;
        bool pointCliked = false;
        public frmSatndardCalculator()
        {
            InitializeComponent();
        }

        bool specialOperator = false;
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtFormula.Text.Length > 0)
            txtResult.Text = txtFormula.Text.Remove(txtFormula.Text.Length - 1);
        }
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFormula.Text = "";
            txtResult.Text = "";
            isEqualCliked = false;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            specialOperator = true;
            txtFormula.Text += "*"+ txtFormula.Text;
            txtResult.Text = (Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text)).ToString();
        }
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            specialOperator = true;
            if (!(string.IsNullOrEmpty(txtFormula.Text)))
            txtFormula.Text=txtFormula.Text.Remove(txtFormula.Text.Length - 1);
            txtFormula.Text = "sqrt("+txtResult.Text+")";
            txtResult.Text = Math.Sqrt(Convert.ToDouble(txtResult.Text)).ToString();              
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
            pointCliked = true;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            isEqualCliked = true;
            txtFormula.Text += txtResult.Text;
            string formula = txtFormula.Text;
            if (!(formula.Contains("=") || specialOperator))
            {
                txtFormula.Text += "=";
                string s = formula;
                txtResult.Text = new DataTable().Compute(formula, null).ToString();
            }
            else
            {
                specialOperator = false;
            }

        }


        private void commonButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text; 
                  
        }

        private void commonOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
                    
            if (isEqualCliked)
             {
                isEqualCliked = false;
                txtFormula.Text = txtResult.Text+btn.Text;
                txtResult.Clear();
            }
             else
             {
                txtFormula.Text += txtResult.Text;
                txtResult.Clear();
                txtFormula.Text += btn.Text;
             }
                  
        }
        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtFormula.Text)))
            txtFormula.Text = txtFormula.Text.Remove(txtFormula.Text.Length - 1);
            txtFormula.Text += "1/" + txtResult.Text;
            txtResult.Text = (1/ Convert.ToDouble(txtResult.Text)).ToString();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            string text = txtResult.Text;
            if (text.Contains("-"))
            {
                txtResult.Text = text.Remove(0, 1);
            }
            else
            {
                txtResult.Text = "-" + text;
            }
        }

    }
}