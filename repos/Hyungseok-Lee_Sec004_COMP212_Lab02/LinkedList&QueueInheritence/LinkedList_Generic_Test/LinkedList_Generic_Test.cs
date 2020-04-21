using System;
using LinkedLIst_Generic;

namespace LinkedList_Generic_Test
{
    class LinkedList_Generic_Test
    {
        static void Main(string[] args)
        {
            Hyungseok_Lee_Excercise03_LinkedList();
        }

        private static void Hyungseok_Lee_Excercise03_LinkedList()
        {
            Console.WriteLine("Excercise 03 - LinkedListLibrary<T>");
            intListEx();
            doubleListEx();
        }

        private static void intListEx()/*A method that instantiates an integer list 
            and inserting values of array into the list. The method also displays all items, the last node's value,
            and the minimum value of a node in the list.*/
        {
            Console.WriteLine("\n Integer list.");
            var intList = new List<int>();
            int[] intArray = new int[5];
            intArray[0] = 12345;
            intArray[1] = 12349;
            intArray[2] = 12341;
            intArray[3] = 12347;
            intArray[4] = 12344;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i == 0)
                {
                    intList.InsertAtFront(intArray[i]);
                }
                else
                {
                    intList.InsertAtBack(intArray[i]);
                }
            }
            Console.WriteLine("\n list of items");
            intList.Display();
            Console.WriteLine("\n the last node value in the list.\n");
            Console.WriteLine(intList.GetLastNode());
            Console.WriteLine("\n the minimum value in the list");
            Console.WriteLine(intList.Minimum());
        }
        private static void doubleListEx()/*A method that instantiates an double list 
            and inserting values of array into the list. The method also displays all items, the last node's value,
            and the minimum value of a node in the list.*/
        {
            Console.WriteLine("\nDouble list");
            var doubleList = new List<double>();
            double[] doubleArray = new double[5];
            doubleArray[0] = 12345.12345;
            doubleArray[1] = 12345.12349;
            doubleArray[2] = 12345.12341;
            doubleArray[3] = 12345.12348;
            doubleArray[4] = 12345.12342;
            for (int i = 0; i < doubleArray.Length; i++)
            {
                if (i == 0)
                {
                    doubleList.InsertAtFront(doubleArray[i]);
                }
                else
                {
                    doubleList.InsertAtBack(doubleArray[i]);
                }
            }
            Console.WriteLine("\n list of items");
            doubleList.Display();
            Console.WriteLine("\n the last node value in the list.\n");
            Console.WriteLine(doubleList.GetLastNode());
            Console.WriteLine("\n the minimum value in the list");
            Console.WriteLine(doubleList.Minimum());
        }
    }
}
