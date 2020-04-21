namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise01
{
    partial class Exercise1
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
            this.queryTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // queryTxtBx
            // 
            this.queryTxtBx.Location = new System.Drawing.Point(44, 45);
            this.queryTxtBx.Multiline = true;
            this.queryTxtBx.Name = "queryTxtBx";
            this.queryTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queryTxtBx.Size = new System.Drawing.Size(656, 354);
            this.queryTxtBx.TabIndex = 0;
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryTxtBx);
            this.Name = "Exercise1";
            this.Text = "Exercise1";
            this.Load += new System.EventHandler(this.Exercise1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryTxtBx;
    }
}

