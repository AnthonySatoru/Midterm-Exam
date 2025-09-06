using System;
using StudentRecordLib;

namespace StudentRecordLib.Actions
{
    public class DisplayStudents : MENU
    {
        public void Execute(SinglyLinkedList list)
        {
            list.Display();
        }
    }
}