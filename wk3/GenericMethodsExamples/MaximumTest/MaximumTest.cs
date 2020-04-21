using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumTest
{
    class MaximumTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}");
            Console.WriteLine(
               $"Minimum of 6.6, 8.8 and 7.7 is {Minimum(6.6, 8.8, 7.7)}");
            Console.WriteLine("Maximum of pear, apple and orange is " +
               $"{Maximum("pear", "apple", "orange")}");
        }

        private static T Maximum<T>(T x, T y, T z) where T : IComparable<T> // called constrainst
        {
            var max = x; // assume x is initially the largest

            // compare y with max
            if (y.CompareTo(max) > 0)
            {
                max = y; // y is the largest so far
            }

            // compare z with max
            if (z.CompareTo(max) > 0)
            {
                max = z; // z is the largest
            }

            return max; // return largest object
        }

        private static T Minimum<T>(T x, T y, T z) where T : IComparable<T> // called constrainst
        {
            var min = x; // assume x is initially the largest

            // compare y with max
            if (y.CompareTo(min) < 0)
            {
                min = y; // y is the largest so far
            }

            // compare z with max
            if (z.CompareTo(min) < 0)
            {
                min = z; // z is the largest
            }

            return min; // return largest object
        }
    }
}
