using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using the C# For Loop");
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                    i, Thread.CurrentThread.ManagedThreadId);

                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            }
            Console.WriteLine();

            Console.WriteLine("Using the Parallel.For Loop");
            Parallel.For(0, n, i =>
            {
                //This block should contain independent code
                //It must not update/use value of some variable from previous iteration 
                //This block should contain a code that takes a huge execution time in each iteration
                //Small complexity code here can result in poor performance

                Console.WriteLine(@"value of i = {0}, thread = {1}",
                    i, Thread.CurrentThread.ManagedThreadId);

                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        }
    }
}
