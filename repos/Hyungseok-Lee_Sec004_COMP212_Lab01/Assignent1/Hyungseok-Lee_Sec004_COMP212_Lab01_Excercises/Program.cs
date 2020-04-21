using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignent1
{
    public delegate bool GradesPredicate(double val);
    class Program
    {
        static void Main(string[] args)
        {
            Hyungseok_Lee_Exercise1();
            Hyungseok_Lee_Exercise2();
        }
        public static void Hyungseok_Lee_Exercise1()
        {
            Console.WriteLine("Excercise 1\n");
            Func<string, string, string, string> MinimumPredicate = Minimum;
            Console.WriteLine(MinimumPredicate("ABC", "ABCD", "ABCDE"));
            AvgPredicate(50.23, 70.34, 80.55);
        }

        public static string Minimum(string str1, string str2, string str3)
        {
            var min = str1;
            if (str2.CompareTo(min) < 0)
                min = str2;
            if (str3.CompareTo(min) < 0)
                min = str3;
            return min;
        }

        //The start of the delegate predicate AvgPredicate that is assigned void method AvgGrade
        private static Action<double, double, double> AvgPredicate = (val1, val2, val3) =>
        {
            double avg = (val1 + val2 + val3) / 3;
            Console.WriteLine($"\nAverage value of 3 grades({val1}, {val2}, {val3}).");
            Console.WriteLine("The average value of 3 values is " + avg.ToString("F2"));
        };//the end of AvgPredicate
        public static void Hyungseok_Lee_Exercise2()
        {
            Console.WriteLine("\nExercise 2\n");
            GradeDisplay();
            GradesPredicate gradesPredicate = val => val >= 50;
            GradesFilter(gradeArray(), gradesPredicate);
        }
        private static void GradeDisplay() // GradeDisplay() that displays all grades in gradeArray
        {
            Console.WriteLine("All generated grades");
            foreach (var grade in gradeArray())
            {
                Console.WriteLine(grade.ToString("F2"));
            }
        }
        private static double[] gradeArray()//GradeArray that contains 10 generated grades; Each grade has a value between 10 and 100.
        {
            Random rnd = new Random();
            double[] gradeArray = new double[10];
            for (int i = 0; i < gradeArray.Length; i++)
            {
                double grade = (10 + Convert.ToDouble(rnd.Next(40, 190))) / Convert.ToDouble(rnd.Next(2, 5));
                gradeArray[i] = grade;
            }
            return gradeArray;
        }
        public static void GradesFilter(double[] grades, GradesPredicate gradesPredicate)
        //GradeFilter method that filters grades under 50 and displays grades that are qual to or greater than 50.
        {
            Console.WriteLine("\nGrades that are equal to or greater than 50.");
            foreach (var grade in grades)
            {
                if (gradesPredicate(grade))
                    Console.WriteLine(grade.ToString("F2"));
            }
        }
    }

}
