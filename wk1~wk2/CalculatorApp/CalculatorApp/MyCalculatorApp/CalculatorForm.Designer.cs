namespace MyCalculatorApp
{
    partial class CalculatorForm
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
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.buttonSUB = new System.Windows.Forms.Button();
            this.buttonMPY = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(111, 98);
            this.labelNumber1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(76, 15);
            this.labelNumber1.TabIndex = 0;
            this.labelNumber1.Text = "Number01:";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(213, 98);
            this.textBoxNumber1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(184, 25);
            this.textBoxNumber1.TabIndex = 1;
            this.textBoxNumber1.TextChanged += new System.EventHandler(this.textBoxNumber1_TextChanged);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(191, 167);
            this.buttonADD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(128, 59);
            this.buttonADD.TabIndex = 2;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.ButtonOperation);
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(500, 98);
            this.labelNumber2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(68, 15);
            this.labelNumber2.TabIndex = 3;
            this.labelNumber2.Text = "Number2:";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(619, 90);
            this.textBoxNumber2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(184, 25);
            this.textBoxNumber2.TabIndex = 4;
            // 
            // buttonSUB
            // 
            this.buttonSUB.Location = new System.Drawing.Point(369, 167);
            this.buttonSUB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSUB.Name = "buttonSUB";
            this.buttonSUB.Size = new System.Drawing.Size(128, 59);
            this.buttonSUB.TabIndex = 5;
            this.buttonSUB.Text = "SUB";
            this.buttonSUB.UseVisualStyleBackColor = true;
            this.buttonSUB.Click += new System.EventHandler(this.ButtonOperation);
            // 
            // buttonMPY
            // 
            this.buttonMPY.Location = new System.Drawing.Point(531, 167);
            this.buttonMPY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMPY.Name = "buttonMPY";
            this.buttonMPY.Size = new System.Drawing.Size(128, 59);
            this.buttonMPY.TabIndex = 6;
            this.buttonMPY.Text = "MPY";
            this.buttonMPY.UseVisualStyleBackColor = true;
            this.buttonMPY.Click += new System.EventHandler(this.ButtonOperation);
            // 
            // buttonDIV
            // 
            this.buttonDIV.Location = new System.Drawing.Point(699, 167);
            this.buttonDIV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(128, 59);
            this.buttonDIV.TabIndex = 7;
            this.buttonDIV.Text = "DIV";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.ButtonOperation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Result:";
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(272, 315);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(473, 36);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "your output here";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1251, 615);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.buttonMPY);
            this.Controls.Add(this.buttonSUB);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.labelNumber1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CalculatorForm";
            this.Text = "SIMPLE CALCULATOR";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Button buttonSUB;
        private System.Windows.Forms.Button buttonMPY;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
    }
}

