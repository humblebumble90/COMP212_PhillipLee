namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise03
{
    partial class Exercise03
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
            this.txtBx_Output = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_Output
            // 
            this.txtBx_Output.Location = new System.Drawing.Point(111, 55);
            this.txtBx_Output.Multiline = true;
            this.txtBx_Output.Name = "txtBx_Output";
            this.txtBx_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_Output.Size = new System.Drawing.Size(592, 383);
            this.txtBx_Output.TabIndex = 0;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(263, 12);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(259, 23);
            this.btn_Calculate.TabIndex = 1;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Exercise03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txtBx_Output);
            this.Name = "Exercise03";
            this.Text = "Exercise03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_Output;
        private System.Windows.Forms.Button btn_Calculate;
    }
}

