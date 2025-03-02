using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormCalculator
{
    partial class frmSatndardCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatndardCalculator));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(432, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 100);
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(289, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 100);
            this.btnClear.TabIndex = 3;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.AutoSize = true;
            this.btnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.ForeColor = System.Drawing.Color.White;
            this.btnClearEntry.Location = new System.Drawing.Point(146, 3);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(137, 100);
            this.btnClearEntry.TabIndex = 1;
            this.btnClearEntry.TabStop = false;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSize = true;
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(3, 3);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(137, 100);
            this.btnPercent.TabIndex = 0;
            this.btnPercent.TabStop = false;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPlusMinus, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnPoint, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtract, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSquare, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnInverse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSquareRoot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPercent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearEntry, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(573, 637);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(146, 533);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(137, 101);
            this.btn0.TabIndex = 28;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.AutoSize = true;
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnPlusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btnPlusMinus.ForeColor = System.Drawing.Color.White;
            this.btnPlusMinus.Location = new System.Drawing.Point(3, 533);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(137, 101);
            this.btnPlusMinus.TabIndex = 27;
            this.btnPlusMinus.TabStop = false;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btnEqual.ForeColor = System.Drawing.Color.White;
            this.btnEqual.Location = new System.Drawing.Point(432, 533);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(138, 101);
            this.btnEqual.TabIndex = 26;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.AutoSize = true;
            this.btnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btnPoint.ForeColor = System.Drawing.Color.White;
            this.btnPoint.Location = new System.Drawing.Point(289, 533);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(137, 101);
            this.btnPoint.TabIndex = 25;
            this.btnPoint.TabStop = false;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(146, 427);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(137, 100);
            this.btn2.TabIndex = 24;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(3, 215);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(137, 100);
            this.btn7.TabIndex = 23;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(289, 427);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(137, 100);
            this.btn3.TabIndex = 22;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(432, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 100);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(289, 321);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(137, 100);
            this.btn6.TabIndex = 20;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(146, 321);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(137, 100);
            this.btn5.TabIndex = 19;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(3, 427);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(137, 100);
            this.btn1.TabIndex = 18;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.AutoSize = true;
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.Location = new System.Drawing.Point(432, 321);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(138, 100);
            this.btnSubtract.TabIndex = 17;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(289, 215);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(137, 100);
            this.btn9.TabIndex = 16;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(146, 215);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(137, 100);
            this.btn8.TabIndex = 15;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(3, 321);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(137, 100);
            this.btn4.TabIndex = 14;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.AutoSize = true;
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.Location = new System.Drawing.Point(432, 215);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(138, 100);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnSquare
            // 
            this.btnSquare.AutoSize = true;
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.Location = new System.Drawing.Point(146, 109);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(137, 100);
            this.btnSquare.TabIndex = 12;
            this.btnSquare.TabStop = false;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnInverse
            // 
            this.btnInverse.AutoSize = true;
            this.btnInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnInverse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInverse.FlatAppearance.BorderSize = 0;
            this.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverse.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnInverse.ForeColor = System.Drawing.Color.White;
            this.btnInverse.Location = new System.Drawing.Point(3, 109);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(137, 100);
            this.btnInverse.TabIndex = 11;
            this.btnInverse.TabStop = false;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = false;
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.AutoSize = true;
            this.btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSquareRoot.FlatAppearance.BorderSize = 0;
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquareRoot.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.btnSquareRoot.ForeColor = System.Drawing.Color.White;
            this.btnSquareRoot.Location = new System.Drawing.Point(289, 109);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(137, 100);
            this.btnSquareRoot.TabIndex = 10;
            this.btnSquareRoot.TabStop = false;
            this.btnSquareRoot.Text = "√x";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.Location = new System.Drawing.Point(432, 109);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(138, 100);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.txtResult.ForeColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(14, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(573, 71);
            this.txtResult.TabIndex = 1;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0 ";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFormula
            // 
            this.txtFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFormula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormula.Enabled = false;
            this.txtFormula.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.txtFormula.ForeColor = System.Drawing.Color.White;
            this.txtFormula.Location = new System.Drawing.Point(14, 28);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ReadOnly = true;
            this.txtFormula.Size = new System.Drawing.Size(576, 63);
            this.txtFormula.TabIndex = 2;
            this.txtFormula.TabStop = false;
            this.txtFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmSatndardCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(600, 826);
            this.Controls.Add(this.txtFormula);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSatndardCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnBack;
        private Button btnClear;
        private Button btnClearEntry;
        private Button btnPercent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn0;
        private Button btnPlusMinus;
        private Button btnEqual;
        private Button btnPoint;
        private Button btn2;
        private Button btn7;
        private Button btn3;
        private Button btnAdd;
        private Button btn6;
        private Button btn5;
        private Button btn1;
        private Button btnSubtract;
        private Button btn9;
        private Button btn8;
        private Button btn4;
        private Button btnMultiply;
        private Button btnSquare;
        private Button btnInverse;
        private Button btnSquareRoot;
        private Button btnDivide;
        private TextBox txtResult;
        private TextBox txtFormula;
    }
}
