namespace WindowsFormCalculator
{
    partial class frmSimpleCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtNumber1.Location = new System.Drawing.Point(205, 34);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(127, 34);
            this.txtNumber1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(38, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "NUMBER 2";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtNumber2.Location = new System.Drawing.Point(205, 87);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(127, 34);
            this.txtNumber2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.txtResult.Location = new System.Drawing.Point(205, 229);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(127, 34);
            this.txtResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(33, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESULT";
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(115, 157);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(54, 39);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "/";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(192, 157);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(54, 39);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(269, 157);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(54, 39);
            this.btnMod.TabIndex = 5;
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // frmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(364, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNumber1);
            this.DoubleBuffered = true;
            this.Name = "frmSimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMod;
    }
}

