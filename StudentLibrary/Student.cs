using System;
namespace StudentLibrary
{
    public class Student
    {
        private int studentId;     // Stores employee ID
        private string studentName;        // Stores employee name 
        private int studentAge;        // Store age 
        private static int studentCount = 0;       // Keeps count on objects created 

        // Create public properties & PascalCase for properites in public
        // Public properties are a way to control access, getters & setters
        public int ID       // Read only property
        {
            get { return studentId; }
        }

        public string Name      // Properties that allow reading and writing ie. get or set name of student
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int Age      // Properties that allow reading and writing ie. get or set age of employee
        {
            get { return studentAge; }
            set { studentAge = value; }
        }


        public static int StudentCount      // Read only property, total count of student objects created
        {
            get { return studentCount; }
        }

        // Task 4 - Default Constructer () <<< NO PARAMETERS
        public Student()
        {
            studentId = studentCount++;
            studentName = "Nathan Mc Garvey";
            studentAge = 31;
        }

        // Custom Constructor takes 'paramters' string / age <<<<<
        public Student(string name, int age)
        {
            studentId = studentCount++;
            studentName = name;
            studentAge = age;
        }

        // Display method must be public with a 'void' return type
        public void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");       // Student name, id & age, output to console
        }

        // Get older method increment employeeAge++ / return . . . e
        public int GetOlder()
        {
            studentAge++;
            return studentAge;
        }

    }
}