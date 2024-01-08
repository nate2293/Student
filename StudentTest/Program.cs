using System;
using StudentLibrary;
namespace StudentTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of an employee in my case
            Student student1 = new Student();
            Student student2 = new Student("Toby Butler", 8);

            // Display details of both students using a 'Display method'
            student1.Display();
            student2.Display();

            // Call the get older method on both objects
            int employee1Age = student1.GetOlder();
            int employee2Age = student2.GetOlder();

            // Now print the details to show increase 
            student1.Display();
            student2.Display();

            Console.WriteLine($"Number of employees:  {Student.StudentCount}");


            student1.Name = "John Smith";
            student1.Age = 31;

            student1.Display();

            Console.ReadLine();

        }

    }
}