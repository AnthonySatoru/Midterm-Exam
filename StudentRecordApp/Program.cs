using System;
using StudentRecordLib;
using StudentRecordLib.Actions;

namespace StudentRecordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            bool running = true;
                         
        
            while (running)
            {
                Console.WriteLine("\n===== Student Record System =====");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Display All Students");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                Console.Clear();

                MENU action = null;

                switch (choice)
                {
                    case "1": action = new InsertStudent(); break;
                    case "2": action = new SearchStudent(); break;
                    case "3": action = new RemoveStudent(); break;
                    case "4": action = new UpdateStudent(); break;
                    case "5": action = new DisplayStudents(); break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                action?.Execute(list);
            }
        }
    }
}