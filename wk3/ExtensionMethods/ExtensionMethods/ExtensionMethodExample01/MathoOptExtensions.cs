using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample01
{
    public static class MathoOptExtensions
    {
        public static double MPY(this MathOps value/* this argument is essential to be called.*/, double num1, double num2)
        {
            return num1 * num2;
        }

        public static double DIV(this MathOps value/* this argument is essential to be called.*/, double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
