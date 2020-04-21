using FibonacciAsynchronous;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyungseok_Lee_COMP212_Sec004_Test02_Exercise03
{
    public partial class Exercise03 : Form
    {
        public Exercise03()
        {
            InitializeComponent();
        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            txtBx_Output.Clear();
            txtBx_Output.Text = "\r\tStarting task to calculate calculateFibonacci(45)";
            Task<TimeData> task1 = Task.Run(() => startFibonacci(45));
            AppendText("\r\n\t Starting task to calculate calculateFacotrial(46)");
            Task<TimeData> task2 = Task.Run(() => startFactorial(46));
            AppendText("\r\n\t Starting task to calculate rollDice(60000000)");
            Task<TimeData> task3 = Task.Run(() => startRolling(60000000));
            await Task.WhenAll(task1, task2, task3);

            DateTime[] startTimes = 
                { task1.Result.StartTime, task2.Result.StartTime, task3.Result.StartTime };
            DateTime[] endTimes = 
                { task1.Result.EndTime, task2.Result.EndTime, task3.Result.EndTime }; ;
            // determine time that first thread started
            DateTime startTime = startTimes.Min();
            // determine time that last thread ended
            DateTime endTime = endTimes.Max();
            // display total time for calculations
            double totalMinutes = (endTime - startTime).TotalMinutes;
            AppendText(
               $"\r\n\t [All tasks are done!]" +
               $"\r\n\tTotal calculation time = {totalMinutes:F6} minutes");
        }
        private long calculateFactorial(int num)
        {

            if (num == 0 || num == 1)
            {
                return num;
            }
            if (num < 0)
            {
                throw new StackOverflowException("Negative value can't be calculated.");
            }
            else
            {
                return num * calculateFactorial(num - 1);
            }
        }
        private long calculateFibonacci(long n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return calculateFibonacci(n - 1) + calculateFibonacci(n - 2);
            }
        }

        private int rollDice(int num)
        {
            Random rnd = new Random();
            int result = 0;
            for(int i = 0; i < num; i++)
            {
                result = rnd.Next(0, 6) + 1;
            }
            return result;
        }

        private TimeData startFibonacci(int num)
        {
            var result = new TimeData();
            AppendText($"\r\n\t Calculating the Fibonacci result of {num}....");
            result.StartTime = DateTime.Now;
            long fibonacciValue = calculateFibonacci(num);
            result.EndTime = DateTime.Now;
            AppendText($"\r\n\t[Done!]\r\n\tCalculateFibonacci({num}) = {fibonacciValue}");
            double minutes =
                (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"\r\n\tCalculation time = {minutes:F6} minutes");
            return result;
        }
        private TimeData startFactorial(int num)
        {
            var result = new TimeData();
            AppendText($"\r\n\t Calculating the factorial result of {num}....");
            result.StartTime = DateTime.Now;
            long factorialValue = calculateFactorial(num);
            result.EndTime = DateTime.Now;
            AppendText($"\r\n\t[Done!]\r\n\tCalculateFactorial({num}) = {factorialValue}");
            double minutes =
                (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"\r\n\tCalculation time = {minutes:F6} minutes");
            return result;
        }
        private TimeData startRolling(int num)
        {
            var result = new TimeData();
            AppendText($"\r\n\t Calculating the rolling dice result of {num}....");
            result.StartTime = DateTime.Now;
            long diceValue = rollDice(num);
            result.EndTime = DateTime.Now;
            AppendText($"\r\n\t[Done!]\r\n\trollDice({num}) = {diceValue}");
            double minutes =
                (result.EndTime - result.StartTime).TotalMinutes;
            AppendText($"\r\n\tCalculation time = {minutes:F6} minutes");
            return result;
        }

        private void AppendText(String text)
        {
            if (InvokeRequired) // not GUI thread, so add to GUI thread
            {
                Invoke(new MethodInvoker(() => AppendText(text)));
            }
            else // GUI thread so append text
            {
                txtBx_Output.AppendText("\r\n\t" + text);
            }
        }
    }
}
