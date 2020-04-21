using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[5];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            for(int i =0; i<intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            List<int> intList = new List<int>();
            for(int i = 0; i<= 5; i++)
            {
                intList.Add(i);
            }
            IEnumerable<int> nums = intList.Where(n => n < 2);
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Queue<int> intQueue = new Queue<int>();
            for(int i = 0; i < 5; i ++)
            {
                intQueue.Enqueue(i);
            }
            foreach(var n in intQueue)
            {
                Console.WriteLine(n);
            }



        }
    }
}
