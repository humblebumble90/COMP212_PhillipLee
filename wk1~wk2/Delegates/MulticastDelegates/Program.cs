using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    public delegate void DelegateOp(int num);
    class Program
    {
        static void Main(string[] args)
        {
            DelegateOp delOp = Square;
            //delOp(5);
            //delOp = MultiplyByTwo;
            //delOp(4);

             delOp += MultiplyByTwo;
            delOp += MultiplyByThree;

            // Calling multicast delegate

            delOp(5); // Will call both the methods

            delOp -= Square; // Remove Square

            delOp(5); // Will only call MultiplyByTwo

        } // end main()

        private static void Square(int val)
        {
            Console.WriteLine($" Square of value: {val * val }");
        }

        private static void MultiplyByTwo(int val)
        {
            Console.WriteLine($" Scalar Multiplication of value by two: {val * 2}");
        }

        private static void MultiplyByThree(int val)
        {
            Console.WriteLine($" Scalar Multiplication of value by Three: {val * 3}");
        }
    } // end Program
} // end namespace
