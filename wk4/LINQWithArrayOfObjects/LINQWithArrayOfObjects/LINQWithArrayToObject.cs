﻿// LINQWithArrayOfObjects.cs
// LINQ to Objects querying an array of Employee objects.
using System;
using System.Linq;
using System.Collections.Generic;
using LINQWithArrayOfObjects;

class LINQWithArrayOfObject
{
   static void Main()
   {
      // initialize array of employees
      var employees = new[] {
         new Employee("Jason", "Red", 5000M),
         new Employee("Ashley", "Green", 7600M),
         new Employee("Matthew", "Indigo", 3587.5M),
         new Employee("James", "Indigo", 4700.77M),
         new Employee("Luke", "Indigo", 6200M),
         new Employee("Jason", "Blue", 3200M),
         new Employee("Wendy", "Brown", 4236.4M)};

      // display all employees
      Console.WriteLine("Original array:");
      foreach (var element in employees)
      {
         Console.WriteLine(element);
      }

      // filter a range of salaries using && in a LINQ query
      var between4K6K =
         from e in employees
         where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
         select e;

      // display employees making between 4000 and 6000 per month
      Console.WriteLine("\nEmployees earning in the range " +   $"{4000:C}-{6000:C} per month:");
      foreach (var element in between4K6K)
      {
         Console.WriteLine(element);
      }

      // order the employees by last name, then first name with LINQ
      var nameSorted =
         from e in employees
         orderby e.LastName, e.FirstName
         select e;


      // header
      Console.WriteLine("\nFirst employee when sorted by name:");

      // attempt to display the first result of the above LINQ query
      if (nameSorted.Any())
      {
         Console.WriteLine(nameSorted.First());
      }
      else
      {
         Console.WriteLine("not found");
      }

      // use LINQ to select employee last names
      var lastNames =
         from e in employees
         select e.LastName;

      // use method Distinct to select unique last names
      Console.WriteLine("\nUnique employee last names:");
      foreach (var element in lastNames.Distinct())
      {
         Console.WriteLine(element);
      }

      // use LINQ to select first and last names
      var names =
         from e in employees
         select new { e.FirstName, e.LastName }; // or
        // select new { FIRST = e.FirstName, LAST= e.LastName };

        // display full names
        Console.WriteLine("\nNames only:");
      foreach (var element in names)
      {
         Console.WriteLine(element);
      }

      Console.WriteLine();
        List<Student> studentList = new List<Student>();
        Student student1 = new Student("Philip", 301011097, 90.50);
        Student student2 = new Student("Polla", 301011098, 80.35);
        Student student3 = new Student("Josh", 301011099, 70.55);
        Student student4 = new Student("Pedro", 301011100, 75.85);
        studentList.AddRange(student1, student2, student3, student4);
        
   }
} 

