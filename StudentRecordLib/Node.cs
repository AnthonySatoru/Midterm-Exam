﻿using StudentRecordLib;

namespace StudentRecordLib
{
    public class Node
    {
        public Student data;
        public Node next;

        public Node(Student data)
        {
            this.data = data;
            this.next = null;
        }
    }
}