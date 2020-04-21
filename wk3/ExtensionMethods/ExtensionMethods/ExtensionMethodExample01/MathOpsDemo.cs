using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample01
{
    class MathOpsDemo
    {
        static void Main(string[] args)
        {
            MathOps mathOps = new MathOps();
            Console.WriteLine(mathOps.ADD(10, 20));
            Console.WriteLine(mathOps.MPY(10, 20));
            Console.WriteLine(mathOps.DIV(10, 20));
            
        } // end Main
    } // end class
} // end namespace
