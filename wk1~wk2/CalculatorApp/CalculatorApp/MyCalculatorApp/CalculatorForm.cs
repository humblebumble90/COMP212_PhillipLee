using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBoxNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOperation(object sender, EventArgs e)
        {
            if (sender.Equals(buttonADD))
            {
                try
                {
                    labelResult.Text = (Convert.ToInt32(textBoxNumber1.Text) + Convert.ToInt32(textBoxNumber2.Text)).ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
                }

            }
            if (sender.Equals(buttonSUB))
            {
                try
                {
                    labelResult.Text = (Convert.ToInt32(textBoxNumber1.Text) - Convert.ToInt32(textBoxNumber2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            if(sender.Equals(buttonMPY))

            {
                try
                {
                    labelResult.Text = (Convert.ToInt32(textBoxNumber1.Text) * Convert.ToInt32(textBoxNumber2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            if(sender.Equals(buttonDIV))
            {
                try
                {
                    labelResult.Text = (Convert.ToInt32(textBoxNumber1.Text) / Convert.ToInt32(textBoxNumber2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
