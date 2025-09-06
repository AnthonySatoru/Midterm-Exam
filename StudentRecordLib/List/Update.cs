using System;

namespace StudentRecordLib.Actions
{
    public class UpdateStudent : MENU
    {
        public void Execute(SinglyLinkedList list)
        {

            Console.WriteLine("Enter Student ID to update:");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter New Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter New Age:");
            int age = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter New Course:");
            string course = Console.ReadLine();

            Console.WriteLine("Enter New Year Level:");
            int year = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Enter GPA:");
            int GPA = int.Parse(Console.ReadLine() ?? "0");

            if (list.Update(id, name, age, course, year, GPA)) 
                
                Console.WriteLine("Student(s) updated successfully!");
            else
                Console.WriteLine("No student found with that ID.");
        }
    }
}