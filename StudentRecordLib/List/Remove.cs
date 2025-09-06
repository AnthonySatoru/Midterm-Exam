using System;

namespace StudentRecordLib.Actions
{
    public class RemoveStudent : MENU
    {
        public void Execute(SinglyLinkedList list)
        {
            Console.WriteLine("Enter Student ID to remove:");
            int id = int.Parse(Console.ReadLine() ?? "0");

            if (list.RemoveAll(id))
                Console.WriteLine("All students with ID " + id + " were removed.");
            else
                Console.WriteLine("No student found with that ID.");
        }
    }
}