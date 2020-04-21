﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParallelForEachExample02
{
    class Program
    {
        static void Main()
        {
            List<int> integerList = Enumerable.Range(0, 10).ToList();
            Parallel.ForEach(integerList, i =>
            {
                Console.WriteLine(@"value of i = {0}, thread = {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
            });

            Console.WriteLine("Press any key to exist");
            Console.ReadLine();
        } 
    } // end class
} // end namespace
