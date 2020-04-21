using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "demonstration of extension methods";
            Console.WriteLine(name.FirstLetterToUppercase());
        } // end Main()

        //TODO:
        //Make every first letter of every word in the string uppercase
        // Make every first letter of every word in the string uppercase if it's lowercase
        // or lowercase if it is uppercase
    }
}
