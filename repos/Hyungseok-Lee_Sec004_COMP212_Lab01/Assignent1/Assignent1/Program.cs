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
            Exercise1();
            Exercise2();
        }
        public static void Exercise1()
        {
            Console.WriteLine("Excercise 1\n");
            Console.WriteLine(MinimumPredicate("9201203.12093810923","2305932059.235095", "23590235903.23049032492034"));
            AvgPredicate(50.23, 70.34, 80.55);
        }
        //The start of deleagte predicate MinimumPredicate that is assigned string Minimum
        private static Func<string, string, string, string> MinimumPredicate = (val1, val2, val3) =>
        {
            Console.WriteLine($"Minimum value of 3 values({val1}, {val2}, {val3}).");
            if (Convert.ToDouble(val1) < Convert.ToDouble(val2) && Convert.ToDouble(val1) < Convert.ToDouble(val3))
            {
                return val1 + "is the minimum value";
            }
            else if (Convert.ToDouble(val2) < Convert.ToDouble(val1) && Convert.ToDouble(val2) < Convert.ToDouble(val3))
            {
                return val2 + "is the minimum value";
            }
            else if (Convert.ToDouble(val3) < Convert.ToDouble(val1) && Convert.ToDouble(val3) < Convert.ToDouble(val2))
            {
                return val3 + "is the minimum value";
            }
            else
                return "All strings have same value";
        };//The end of MinimumPredicate
        //The start of the delegate predicate AvgPredicate that is assigned void method AvgGrade
        private static Action<double, double, double> AvgPredicate = (val1, val2, val3) =>
        {
            double avg = (val1 + val2 + val3) / 3;
            Console.WriteLine($"\nAverage value of 3 grades({val1}, {val2}, {val3}).");
            Console.WriteLine(avg.ToString("F2"));
        };//the end of AvgPredicate
        public static void Exercise2()
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
            foreach(var grade in grades)
            {
                if(gradesPredicate(grade))
                Console.WriteLine(grade.ToString("F2"));
            }
        }
    }

}
