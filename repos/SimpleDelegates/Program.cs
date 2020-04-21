using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegates
{
    // delegate is a function pointer. It hold the reference of a method
    public delegate void DelegateSum(int val1, int val2);
    public delegate int DelegateDiff(int val1, int val2);
    public delegate Double DelegateMPY(double val1, double val2);
    public delegate string Delgate3();
    public delegate bool Delegate4(string str);
    public delegate int Delegate5(string str, int num);
    class Program
    {
        static void Main(string[] args)
        {
            // about Func<> and Action<>
            Sum(10, 20);
            Console.WriteLine($"Diff of values : {Diff(20, 10)}");
            int diff = Diff(20, 10);
            Console.WriteLine($"MPY of values : {MPY(20, 10)}");
            Console.WriteLine($"DIV of values : {DIV(20, 10)}");
            Console.WriteLine("\n Calling using Delegate");
            DelegateSum delSum = Sum; // this assigns the reference of Sum to delSum

            Func<int,int,int> delDiff2 = Diff;
            //Func<int,int, string> FuncDel = SomeMethod1;
            //Func<int, string> FuncDel2 = SomeMethod2;
            //Func<double, double, string> FuncDel3 = SomeMethod3;
            //The last First and rest of state ments except last one is conditional statements and the last one is return value.

            //Action <t>delegate is to refer void method
            //Action(<int, int, int, string> funDel = SomeMethod4;
            //Action(<int, int, string> funDel = SomeMethod5;
            //Action(<double, double, string> funDel = SomeMethod6;


            DelegateDiff delDiff = Diff;
            Console.WriteLine($"Using delegate Diff of values: {delDiff(20, 10)}");
            DelegateMPY delMpy = MPY;
            Console.WriteLine($"Using delegate MPY of values : {MPY(20, 10)}");
            //Console.WriteLine(delSum);
            //Call using delegate
            delSum(100, 200); // this is method call to SUm using delegate
            delSum(50, 30); // this is method call to SUm using delegate


        }//end main 

        private static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            //Console.WriteLine($" sum of values: {num1 + num2}");
            Console.WriteLine($" sum of values: {sum}");
        }

        private static int Diff(int num1, int num2)
        {
            int diff = num1 - num2;
            return diff;
        }
        private static double MPY(double num1, double num2)
        {
            double mul = num1 * num2;
            return mul;
        }
        private static double DIV(double num1, double num2)
        {
            double div = num1 / num2;
            return div;
        }
    }//end class
}//end namespace
