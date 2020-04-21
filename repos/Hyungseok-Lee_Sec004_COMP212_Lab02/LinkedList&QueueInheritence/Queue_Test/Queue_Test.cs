using System;
using LinkedLIst_Generic;
using QueueInheritance;
namespace Queue_Test
{
    class Queue_Test
    {
        static void Main(string[] args)
        {
            Hyungseok_Lee_Excercise03_QueueInheritance();
        }
        private static void Hyungseok_Lee_Excercise03_QueueInheritance()
        {
            QueTest_Integer();
            QueTest_Double();
        }
        private static void QueTest_Integer()/*The method that instantiates an integer queue,
            displays items, the last node value, and the minimum value in the queue.*/
        {
            QueueInheritance<int> intQueue = new QueueInheritance<int>();
            for(int i = 0; i < intArray().Length; i++)
            {
                intQueue.Enqueue(intArray()[i]);
            }
            intQueue.Display();
            Console.WriteLine($"The last value of this que is {intQueue.GetLastNode()}");
            Console.WriteLine($"The minimum value of this que is {intQueue.Minimum()}");
        }
        private static int[] intArray()// The method maks a integer array that can contain 10 integer values.
        {
            int[] intArray = new int[10];
            for(int i = 0; i< intArray.Length; i++)
            {
                intArray[i] = 923 + 8*(i+1);
            }
            return intArray;
        }
        private static void QueTest_Double()/*The method that instantiates an double queue,
            displays items, the last node value, and the minimum value in the queue.*/
        {
            QueueInheritance<double> doubleQueue = new QueueInheritance<double>();
            for(int i = 0; i < doubleArray().Length; i++)
            {
                doubleQueue.Enqueue(doubleArray()[i]);
            }
            doubleQueue.Display();
            Console.WriteLine($"The last value of this que is {doubleQueue.GetLastNode()}");
            Console.WriteLine($"The minimum value of this que is {doubleQueue.Minimum()}");


        }
        private static double[] doubleArray()// The method maks a integer array that can contain 10 double values.
        {
            double[] doubleArray = new double[10];
            doubleArray[0] = 125631.1531163;
            doubleArray[1] = 125631.1533466;
            doubleArray[2] = 125631.6533416;
            doubleArray[3] = 125631.6532312;
            doubleArray[4] = 125631.6534978;
            doubleArray[5] = 125631.6534335;
            doubleArray[6] = 125631.6531236;
            doubleArray[7] = 125631.6531143;
            doubleArray[8] = 125631.6534565;
            doubleArray[9] = 125631.6532314;
            return doubleArray;
        }
    }
}
