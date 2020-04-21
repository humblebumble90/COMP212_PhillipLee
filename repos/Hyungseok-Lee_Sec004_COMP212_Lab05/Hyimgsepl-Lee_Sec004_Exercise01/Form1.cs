using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyimgsepl_Lee_Sec004_Exercise01
{
    public delegate bool IsOddPredicate(int val);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                long input = Convert.ToInt32(txtBx_Factorial.Text);

                lb_FactorialResult.Text = "Calculating....";

                Task<long> factorialTask = Task.Run(() => Factorial(input));

                await factorialTask;

                lb_FactorialResult.Text = factorialTask.Result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The value is not an integer or out of range.");
            }
        }

        private long Factorial(long num)
        {
            if(num == 0 || num == 1)
            {
                return num;
            }
            if(num <0)
            {
                throw new StackOverflowException("Negative value can't be calculated.");
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_chckEvenOrOdd_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(txtBx_InputNumber.Text);
                Func<int, bool> isEvenPredicate = isEven;
                IsOddPredicate isOddPredicate = val => val % 2 == 1;
                if (isEvenPredicate(input))
                {
                    MessageBox.Show
                        ($"The entered value {input} is an even number.", "Result");
                }
                else if (isOddPredicate(input))
                {
                    MessageBox.Show
                        ($"The entered value {input} is an odd number.", "Result");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show
                    ("The value is not an integer or out of range.", "Invalid value");
            }
            
        }

        private bool isEven(int val)
        {
            if(val % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_GenerateValues_Click(object sender, EventArgs e)
        {
            listBx.Items.Clear();
            Random rnd = new Random();
            if (radioBtn_Integer.Checked)
            {
                int[] integers = Enumerable.Range(0, 10)
                    .Select(x => rnd.Next(10, 100)).ToArray();
                foreach(var num in integers)
                {
                    listBx.Items.Add(num);
                }
            }
            if(radio_Btn_Doubles.Checked)
            {
                double[] doubles = Enumerable.Range(0, 10)
                    .Select(x => rnd.Next(10,100) +
                    rnd.NextDouble())
                    .ToArray();
                foreach (var num in doubles)
                {
                    listBx.Items.Add(num);
                }
            }
            if(radio_Btn_Char.Checked)
            {
                char[] chars = Enumerable.Range(0, 10)
                    .Select(x => Convert.ToChar(rnd.Next(10, 100)))
                    .ToArray();
                foreach (var num in chars)
                {
                    listBx.Items.Add(num);
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            foreach(var element in listBx.Items)
            {
                list.Add(element.ToString());
            }
            var input = txtBx_InputValueForSearch.Text;
            if (SearchData(list, input))
            {
                MessageBox
                    .Show($"The searching item {input} is in the list.", "Result");
            }
            else
            {
                MessageBox
                .Show($"The searching item {input} is not in the list.", "Result");
            }

        }
        private bool SearchData<T>(List<T> list, T val) where T:IComparable<T>
        {
            bool result = false;
            foreach(var element in list)
            {
                if (element.CompareTo(val) == 0)
                {
                    result = true;
                }
            }
            return result;
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            try
            {
                int lowIndex = int.Parse(txtBx_InputLowIndex.Text);
                int highIndex = int.Parse(txtBx_InputHighIndex.Text);
                display(lowIndex, highIndex);
            }
            catch(Exception ex)
            {
                MessageBox
                    .Show("The value is not an integer or out of range.","Invalid");
            }
        }

        private void display(int lowIndex, int highIndex)
        {
            richTxtBx_OutputOfValues.Clear();
            List<string> strList = new List<string>();

            foreach (var element in listBx.Items)
            {
                strList.Add(element.ToString());
            }

            if (strList.Count() > 0)
            {
                var result = strList

                .Where(x => x.CompareTo(lowIndex.ToString()) > 0 &&
                x.CompareTo(highIndex.ToString()) < 0);
                foreach (var element in result)
                {
                    richTxtBx_OutputOfValues.AppendText(element + " ");
                }
            }

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
