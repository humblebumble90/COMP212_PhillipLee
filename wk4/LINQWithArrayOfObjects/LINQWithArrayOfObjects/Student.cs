using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithArrayOfObjects
{
    public class Student
    {
        string Name { get; set; }
        int ID { get; set; }
        double Grade { get; set; }
        public Student(string name,int id, double grade)
        {
            Name = name;
            ID = id;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"\nName: {Name}\n ID: {ID}\n Grade:{Grade}";
        }

    }
}
