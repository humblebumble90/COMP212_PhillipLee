using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelMethodInvokeExample
{
    // Demonstrated features:
    // 		Parallel.Invoke()
    // Expected results:
    // 		The threads on which each task gets executed may be different.
    //		The thread assignments may be different in different executions.
    //		The tasks may get executed in any order.
    public class Program
    {
        static void Main()
        {
            try
            {
                Parallel.Invoke(
                     NormalAction,	// Param #0 - static method
                     delegate ()    // Param #1 - in-line delegate 
                     {
                         Console.WriteLine("Method 2, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                     },
                    () =>			// Param #2 - lambda expression
                    {
                        Console.WriteLine("Method 3, Thread={0}", Thread.CurrentThread.ManagedThreadId);
                    }
                );

                //Parallel.Invoke(
                //     NormalAction,	// Param #0 - static method
                //     NormalAction2,
                //     NormalAction3
                //);

                Console.WriteLine("Press any key to exist.");
                Console.ReadKey();
            }
            // No exception is expected in this example, but if one is still thrown from a task,
            // it will be wrapped in AggregateException and propagated to the main thread.
            catch (AggregateException e)
            {
                Console.WriteLine("An action has thrown an exception. THIS WAS UNEXPECTED.\n{0}",
                    e.InnerException.ToString());
            }
        }

        static void NormalAction()
        {
            Console.WriteLine("Method 1, Thread={0}", Thread.CurrentThread.ManagedThreadId);
        }

        //static void NormalAction2()
        //{
        //    Console.WriteLine("NormalAction Method 2, Thread={0}", Thread.CurrentThread.ManagedThreadId);
        //}
        //static void NormalAction3()
        //{
        //    Console.WriteLine("NormalAction Method 3, Thread={0}", Thread.CurrentThread.ManagedThreadId);
        //}
    }
}
