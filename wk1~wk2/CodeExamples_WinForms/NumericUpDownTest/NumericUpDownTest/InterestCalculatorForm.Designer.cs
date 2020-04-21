namespace NumericUpDownTest
{
   partial class InterestCalculatorForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.interestLabel = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.principalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(278, 10);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 31);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.displayTextBox.Location = new System.Drawing.Point(12, 133);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayTextBox.Size = new System.Drawing.Size(296, 109);
            this.displayTextBox.TabIndex = 16;
            this.displayTextBox.TextChanged += new System.EventHandler(this.displayTextBox_TextChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(12, 105);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(163, 20);
            this.balanceLabel.TabIndex = 15;
            this.balanceLabel.Text = "Yearly account balance:";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(119, 70);
            this.yearUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.ReadOnly = true;
            this.yearUpDown.Size = new System.Drawing.Size(117, 27);
            this.yearUpDown.TabIndex = 14;
            this.yearUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearUpDown.ValueChanged += new System.EventHandler(this.yearUpDown_ValueChanged);
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(48, 72);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(46, 20);
            this.yearsLabel.TabIndex = 13;
            this.yearsLabel.Text = "Years:";
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(119, 38);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(116, 27);
            this.interestTextBox.TabIndex = 12;
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(12, 44);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(95, 20);
            this.interestLabel.TabIndex = 11;
            this.interestLabel.Text = "Interest Rate:";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(119, 10);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(116, 27);
            this.principalTextBox.TabIndex = 10;
            // 
            // principalLabel
            // 
            this.principalLabel.AutoSize = true;
            this.principalLabel.Location = new System.Drawing.Point(31, 15);
            this.principalLabel.Name = "principalLabel";
            this.principalLabel.Size = new System.Drawing.Size(69, 20);
            this.principalLabel.TabIndex = 9;
            this.principalLabel.Text = "Principal:";
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 252);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.principalLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InterestCalculatorForm";
            this.Text = "Interest Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button calculateButton;
      private System.Windows.Forms.TextBox displayTextBox;
      private System.Windows.Forms.Label balanceLabel;
      private System.Windows.Forms.NumericUpDown yearUpDown;
      private System.Windows.Forms.Label yearsLabel;
      private System.Windows.Forms.TextBox interestTextBox;
      private System.Windows.Forms.Label interestLabel;
      private System.Windows.Forms.TextBox principalTextBox;
      private System.Windows.Forms.Label principalLabel;
   }
}

