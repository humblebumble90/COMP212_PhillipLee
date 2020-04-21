using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyungseok_Lee_Sec004_COMP212_Lab02
{
    public delegate void DisplayDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Hyungseok_Lee_Excercise01();
            Hyungseok_Lee_Excercise02();
        }
        private static void Hyungseok_Lee_Excercise01()
        {
            Console.WriteLine("Excercise 1");
            DisplayDelegate displayDelegate = DisplayArray; // Assignin a void method to a delegate
            displayDelegate();//Implement the method through the delegate.
            Console.WriteLine("The searched element's location is " + Search(myArray1(), 5)
                + "\nIf the element is not found, the value is -1\n");//Print searched number and explains when the result value is -1.
            Console.WriteLine("The searched element's location is " + Search(myArray2(), 'D')
    + "\nIf the element is not found, the value is -1");//Print searched number and explains when the result value is -1.
        }
        private static int Search<T>(T[] dataArray, T searchKey) where T : IComparable<T>//Start of Search<T> method.
        {
            var result = -1; //Assign -1 to the result value for if there is no matching item with searchKey in the array
            for (int i = 0; i < dataArray.Length; i++)//For loop to search a matching item with searchKey in the array.
            {
                if(dataArray[i].CompareTo(searchKey) == 0)//if statement for if a item is matching with searchKey.
                {
                    result = Array.IndexOf(dataArray, searchKey); // Assgin an index value of searched element's location.
                }
            }
            return result; // return a result value after searching the matching value with searchKey.
        }//End of Search<T> method.
        private static void DisplayArray()//Method to dsplay all items in the array.
        {
            Console.WriteLine("Items in the int array.");
            foreach(var item in myArray1())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Items in the char array.");
            foreach (var item in myArray2())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        private static int[] myArray1()//Generate myArray which has 10 length and items 0 to 10.
        {
            int[] myArray = new int[10];
            for(int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            return myArray;
        }
        private static char[] myArray2()
        {
            string str = "ABCDEFGHIJ";
            char[] myArray = new char[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = str.ToCharArray()[i];
            }
            return myArray;
        }
        private static void Hyungseok_Lee_Excercise02()
        {
            Console.WriteLine("\nExcercise 2");
            Console.WriteLine("Word counter by using extension method.");
            //Declare different types of objects
            StringBuilder sb = new StringBuilder("Holycoooow");//Instantiate the class StringBuilder to use a its extension.
            StringBuilderExtensions sE = new StringBuilderExtensions();
            Console.WriteLine(sE.Count(sb));//Implementing method with the Intantiated object sB as a required parameter.
        }

    }
}
