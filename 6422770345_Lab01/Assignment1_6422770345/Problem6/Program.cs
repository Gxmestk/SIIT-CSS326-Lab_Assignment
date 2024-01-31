//Create a C# program that acts as a simple DBMS for managing a list of
//students. Implement the following features: (2.5 points)
//(i)Create a Student class with properties: Id(int), Name(string), and Age
//(int).
//(ii)Create a menu-based program that allows users to:
//a.Add a new student(Input: Name and Age).
//b.Display the list of all the students.
//c. Search for a student by their ID.

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace prob6
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static int nstud = 0;

        public static List<Student> lst = new List<Student>();

        public Student(string Name, int Age)
        {
            this.Id = ++nstud;
            this.Name = Name;
            this.Age = Age;
            lst.Add(this);
            Console.WriteLine("Student added successfully!");
        }

        public static void list_stud()
        {
            Console.WriteLine("-----List of Students -----");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("ID: " + lst[i].Id + " Name: " + lst[i].Name + " Age: " + lst[i].Age);
            }
            
        }

        public static void find_stud()
        {
            Console.WriteLine("Enter student ID to search: ");
            int Id = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0;i < lst.Count;i++)
            {
                if (lst[i].Id == Id)
                {
                    Console.WriteLine("---- - Student Found---- -");
                    Console.WriteLine("ID: " + lst[i].Id + " Name: " + lst[i].Name + " Age: " + lst[i].Age);
                    return;
                }
            }
            Console.WriteLine("Student with ID {0} not found.", Id);
        }
    }
    class Prob6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ===== Student Management System =====");
            Console.WriteLine("1.Add a new student");
            Console.WriteLine("2.Display all students");
            Console.WriteLine("3.Search student by ID");
            Console.WriteLine("4.Exit");

            while (true)
            {
                string c = Console.ReadLine();
                if (c == "1")
                {
                    Console.Write("Enter student's name: ");
                    string stud_name = Console.ReadLine();
                    Console.Write("Enter student's age: ");
                    int stud_age = Convert.ToInt32(Console.ReadLine());
                    new Student(stud_name, stud_age);
                }
                else if (c == "2")
                {
                    Student.list_stud();
                }
                else if (c == "3")
                {
                    Student.find_stud();
                }
                else if (c == "4")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }

            }

        }
    }
}