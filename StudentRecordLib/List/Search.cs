using System;
using StudentRecordLib;

namespace StudentRecordLib.Actions
{
    public class SearchStudent : MENU
    {
        public void Execute(SinglyLinkedList list)
        {
            Console.Write("Search by 1-ID or 2-Name? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter ID: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                    list.SearchAll(id);
                else
                    Console.WriteLine("Invalid ID.");
            }
            else if (choice == "2")
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                list.SearchByName(name);
            }
            else
                Console.WriteLine("Invalid search type.");
        }
    }
}