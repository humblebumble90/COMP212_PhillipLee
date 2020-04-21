namespace Hyimgsepl_Lee_Sec004_Exercise01
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_FactorialResult = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txtBx_Factorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_chckEvenOrOdd = new System.Windows.Forms.Button();
            this.txtBx_InputNumber = new System.Windows.Forms.TextBox();
            this.lb_InputNumber = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBx = new System.Windows.Forms.ListBox();
            this.richTxtBx_OutputOfValues = new System.Windows.Forms.RichTextBox();
            this.lb_OutputOfValues = new System.Windows.Forms.Label();
            this.txtBx_InputHighIndex = new System.Windows.Forms.TextBox();
            this.txtBx_InputLowIndex = new System.Windows.Forms.TextBox();
            this.txtBx_InputValueForSearch = new System.Windows.Forms.TextBox();
            this.lb_InputHighIndex = new System.Windows.Forms.Label();
            this.lb_InputLowIndex = new System.Windows.Forms.Label();
            this.lb_InputValueForSearch = new System.Windows.Forms.Label();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_GenerateValues = new System.Windows.Forms.Button();
            this.radio_Btn_Char = new System.Windows.Forms.RadioButton();
            this.radio_Btn_Doubles = new System.Windows.Forms.RadioButton();
            this.radioBtn_Integer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_FactorialResult);
            this.groupBox1.Controls.Add(this.btn_Calculate);
            this.groupBox1.Controls.Add(this.txtBx_Factorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // lb_FactorialResult
            // 
            this.lb_FactorialResult.AutoSize = true;
            this.lb_FactorialResult.Location = new System.Drawing.Point(159, 93);
            this.lb_FactorialResult.Name = "lb_FactorialResult";
            this.lb_FactorialResult.Size = new System.Drawing.Size(0, 18);
            this.lb_FactorialResult.TabIndex = 3;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Calculate.Location = new System.Drawing.Point(10, 90);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(123, 42);
            this.btn_Calculate.TabIndex = 2;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txtBx_Factorial
            // 
            this.txtBx_Factorial.Location = new System.Drawing.Point(162, 52);
            this.txtBx_Factorial.Name = "txtBx_Factorial";
            this.txtBx_Factorial.Size = new System.Drawing.Size(154, 26);
            this.txtBx_Factorial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get factorial of:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_chckEvenOrOdd);
            this.groupBox2.Controls.Add(this.txtBx_InputNumber);
            this.groupBox2.Controls.Add(this.lb_InputNumber);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Check for Even/Odd";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_chckEvenOrOdd
            // 
            this.btn_chckEvenOrOdd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_chckEvenOrOdd.Location = new System.Drawing.Point(39, 155);
            this.btn_chckEvenOrOdd.Name = "btn_chckEvenOrOdd";
            this.btn_chckEvenOrOdd.Size = new System.Drawing.Size(206, 23);
            this.btn_chckEvenOrOdd.TabIndex = 2;
            this.btn_chckEvenOrOdd.Text = "Check for Even or Odd";
            this.btn_chckEvenOrOdd.UseVisualStyleBackColor = true;
            this.btn_chckEvenOrOdd.Click += new System.EventHandler(this.btn_chckEvenOrOdd_Click);
            // 
            // txtBx_InputNumber
            // 
            this.txtBx_InputNumber.Location = new System.Drawing.Point(122, 77);
            this.txtBx_InputNumber.Name = "txtBx_InputNumber";
            this.txtBx_InputNumber.Size = new System.Drawing.Size(194, 26);
            this.txtBx_InputNumber.TabIndex = 1;
            // 
            // lb_InputNumber
            // 
            this.lb_InputNumber.AutoSize = true;
            this.lb_InputNumber.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_InputNumber.Location = new System.Drawing.Point(16, 77);
            this.lb_InputNumber.Name = "lb_InputNumber";
            this.lb_InputNumber.Size = new System.Drawing.Size(100, 15);
            this.lb_InputNumber.TabIndex = 0;
            this.lb_InputNumber.Text = "Input number: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBx);
            this.groupBox3.Controls.Add(this.richTxtBx_OutputOfValues);
            this.groupBox3.Controls.Add(this.lb_OutputOfValues);
            this.groupBox3.Controls.Add(this.txtBx_InputHighIndex);
            this.groupBox3.Controls.Add(this.txtBx_InputLowIndex);
            this.groupBox3.Controls.Add(this.txtBx_InputValueForSearch);
            this.groupBox3.Controls.Add(this.lb_InputHighIndex);
            this.groupBox3.Controls.Add(this.lb_InputLowIndex);
            this.groupBox3.Controls.Add(this.lb_InputValueForSearch);
            this.groupBox3.Controls.Add(this.btn_Display);
            this.groupBox3.Controls.Add(this.btn_Search);
            this.groupBox3.Controls.Add(this.btn_GenerateValues);
            this.groupBox3.Controls.Add(this.radio_Btn_Char);
            this.groupBox3.Controls.Add(this.radio_Btn_Doubles);
            this.groupBox3.Controls.Add(this.radioBtn_Integer);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F);
            this.groupBox3.Location = new System.Drawing.Point(378, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 379);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of  Values and Search";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // listBx
            // 
            this.listBx.FormattingEnabled = true;
            this.listBx.ItemHeight = 18;
            this.listBx.Location = new System.Drawing.Point(19, 84);
            this.listBx.Name = "listBx";
            this.listBx.Size = new System.Drawing.Size(69, 274);
            this.listBx.TabIndex = 18;
            // 
            // richTxtBx_OutputOfValues
            // 
            this.richTxtBx_OutputOfValues.Location = new System.Drawing.Point(143, 318);
            this.richTxtBx_OutputOfValues.Name = "richTxtBx_OutputOfValues";
            this.richTxtBx_OutputOfValues.Size = new System.Drawing.Size(267, 50);
            this.richTxtBx_OutputOfValues.TabIndex = 17;
            this.richTxtBx_OutputOfValues.Text = "";
            this.richTxtBx_OutputOfValues.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // lb_OutputOfValues
            // 
            this.lb_OutputOfValues.AutoSize = true;
            this.lb_OutputOfValues.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lb_OutputOfValues.Location = new System.Drawing.Point(94, 292);
            this.lb_OutputOfValues.Name = "lb_OutputOfValues";
            this.lb_OutputOfValues.Size = new System.Drawing.Size(262, 18);
            this.lb_OutputOfValues.TabIndex = 16;
            this.lb_OutputOfValues.Text = "Output Of Values Between Low and High:";
            // 
            // txtBx_InputHighIndex
            // 
            this.txtBx_InputHighIndex.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtBx_InputHighIndex.Location = new System.Drawing.Point(269, 234);
            this.txtBx_InputHighIndex.Name = "txtBx_InputHighIndex";
            this.txtBx_InputHighIndex.Size = new System.Drawing.Size(82, 26);
            this.txtBx_InputHighIndex.TabIndex = 15;
            // 
            // txtBx_InputLowIndex
            // 
            this.txtBx_InputLowIndex.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtBx_InputLowIndex.Location = new System.Drawing.Point(269, 163);
            this.txtBx_InputLowIndex.Name = "txtBx_InputLowIndex";
            this.txtBx_InputLowIndex.Size = new System.Drawing.Size(82, 26);
            this.txtBx_InputLowIndex.TabIndex = 14;
            // 
            // txtBx_InputValueForSearch
            // 
            this.txtBx_InputValueForSearch.Location = new System.Drawing.Point(269, 85);
            this.txtBx_InputValueForSearch.Name = "txtBx_InputValueForSearch";
            this.txtBx_InputValueForSearch.Size = new System.Drawing.Size(82, 26);
            this.txtBx_InputValueForSearch.TabIndex = 13;
            // 
            // lb_InputHighIndex
            // 
            this.lb_InputHighIndex.AutoSize = true;
            this.lb_InputHighIndex.Font = new System.Drawing.Font("Calibri", 9F);
            this.lb_InputHighIndex.Location = new System.Drawing.Point(133, 234);
            this.lb_InputHighIndex.Name = "lb_InputHighIndex";
            this.lb_InputHighIndex.Size = new System.Drawing.Size(114, 18);
            this.lb_InputHighIndex.TabIndex = 12;
            this.lb_InputHighIndex.Text = "Input High Index:";
            // 
            // lb_InputLowIndex
            // 
            this.lb_InputLowIndex.AutoSize = true;
            this.lb_InputLowIndex.Font = new System.Drawing.Font("Calibri", 9F);
            this.lb_InputLowIndex.Location = new System.Drawing.Point(140, 163);
            this.lb_InputLowIndex.Name = "lb_InputLowIndex";
            this.lb_InputLowIndex.Size = new System.Drawing.Size(111, 18);
            this.lb_InputLowIndex.TabIndex = 11;
            this.lb_InputLowIndex.Text = "Input Low Index:";
            // 
            // lb_InputValueForSearch
            // 
            this.lb_InputValueForSearch.AutoSize = true;
            this.lb_InputValueForSearch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lb_InputValueForSearch.Location = new System.Drawing.Point(94, 90);
            this.lb_InputValueForSearch.Name = "lb_InputValueForSearch";
            this.lb_InputValueForSearch.Size = new System.Drawing.Size(153, 18);
            this.lb_InputValueForSearch.TabIndex = 10;
            this.lb_InputValueForSearch.Text = "Input  Value For Search:";
            // 
            // btn_Display
            // 
            this.btn_Display.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_Display.Location = new System.Drawing.Point(371, 207);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 31);
            this.btn_Display.TabIndex = 9;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(371, 85);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 31);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_GenerateValues
            // 
            this.btn_GenerateValues.Font = new System.Drawing.Font("Calibri", 9F);
            this.btn_GenerateValues.Location = new System.Drawing.Point(328, 28);
            this.btn_GenerateValues.Name = "btn_GenerateValues";
            this.btn_GenerateValues.Size = new System.Drawing.Size(118, 37);
            this.btn_GenerateValues.TabIndex = 7;
            this.btn_GenerateValues.Text = "Generate Values";
            this.btn_GenerateValues.UseVisualStyleBackColor = true;
            this.btn_GenerateValues.Click += new System.EventHandler(this.btn_GenerateValues_Click);
            // 
            // radio_Btn_Char
            // 
            this.radio_Btn_Char.AutoSize = true;
            this.radio_Btn_Char.Font = new System.Drawing.Font("Calibri", 9F);
            this.radio_Btn_Char.Location = new System.Drawing.Point(183, 35);
            this.radio_Btn_Char.Name = "radio_Btn_Char";
            this.radio_Btn_Char.Size = new System.Drawing.Size(57, 22);
            this.radio_Btn_Char.TabIndex = 6;
            this.radio_Btn_Char.TabStop = true;
            this.radio_Btn_Char.Text = "Char";
            this.radio_Btn_Char.UseVisualStyleBackColor = true;
            // 
            // radio_Btn_Doubles
            // 
            this.radio_Btn_Doubles.AutoSize = true;
            this.radio_Btn_Doubles.Font = new System.Drawing.Font("Calibri", 9F);
            this.radio_Btn_Doubles.Location = new System.Drawing.Point(97, 35);
            this.radio_Btn_Doubles.Name = "radio_Btn_Doubles";
            this.radio_Btn_Doubles.Size = new System.Drawing.Size(80, 22);
            this.radio_Btn_Doubles.TabIndex = 5;
            this.radio_Btn_Doubles.TabStop = true;
            this.radio_Btn_Doubles.Text = "Doubles";
            this.radio_Btn_Doubles.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Integer
            // 
            this.radioBtn_Integer.AutoSize = true;
            this.radioBtn_Integer.Font = new System.Drawing.Font("Calibri", 9F);
            this.radioBtn_Integer.Location = new System.Drawing.Point(19, 33);
            this.radioBtn_Integer.Name = "radioBtn_Integer";
            this.radioBtn_Integer.Size = new System.Drawing.Size(80, 22);
            this.radioBtn_Integer.TabIndex = 4;
            this.radioBtn_Integer.TabStop = true;
            this.radioBtn_Integer.Text = "Integers";
            this.radioBtn_Integer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Asynchronous Programming";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txtBx_Factorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_chckEvenOrOdd;
        private System.Windows.Forms.TextBox txtBx_InputNumber;
        private System.Windows.Forms.Label lb_InputNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTxtBx_OutputOfValues;
        private System.Windows.Forms.Label lb_OutputOfValues;
        private System.Windows.Forms.TextBox txtBx_InputHighIndex;
        private System.Windows.Forms.TextBox txtBx_InputLowIndex;
        private System.Windows.Forms.TextBox txtBx_InputValueForSearch;
        private System.Windows.Forms.Label lb_InputHighIndex;
        private System.Windows.Forms.Label lb_InputLowIndex;
        private System.Windows.Forms.Label lb_InputValueForSearch;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_GenerateValues;
        private System.Windows.Forms.RadioButton radio_Btn_Char;
        private System.Windows.Forms.RadioButton radio_Btn_Doubles;
        private System.Windows.Forms.RadioButton radioBtn_Integer;
        private System.Windows.Forms.Label lb_FactorialResult;
        private System.Windows.Forms.ListBox listBx;
    }
}

