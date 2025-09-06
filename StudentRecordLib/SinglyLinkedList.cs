using System;

namespace StudentRecordLib
{
    public class SinglyLinkedList
    {
        private Node head;  
        private Node tail;  

        private bool IsDuplicatedID(int id)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.ID == id)
                    return true;
                temp = temp.next;
            }
            return false;
        }

        public void Insert(Student student)
        {
            if (IsDuplicatedID(student.ID))
            {
                Console.WriteLine($"Insert failed: Studee nt ID {student.ID} already exists.");
                return;
            }

            Node newNode = new Node(student);

            if (head == null) 
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode; 
                tail = newNode;      
            }

            Console.WriteLine("Student inserted successfully.");
        }

        public void InsertEnd(Student student)
        {
            Node newNode = new Node(student);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            Console.WriteLine("Student inserted successfully.");
        }
        public void InsertPosition(Student student, int position)
        {
            Node newNode = new Node(student);

            if (head == null || position <= 1)
            {
                
                newNode.next = head;
                head = newNode;
                if (tail == null)
                    tail = newNode;
                return;
            }

            Node current = head;
            int index = 1;

            while (current != null && index < position - 1)
            {
                current = current.next;
                index++;
            }

            if (current == null) 
            {
                tail.next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = current.next;
                current.next = newNode;
                if (newNode.next == null)
                    tail = newNode; 
            }
        }
        public void SearchAll(int id)
        {
            Node current = head;
            bool foundAny = false;

            while (current != null)
            {
                if (current.data.ID == id)
                {
                    Console.WriteLine(current.data);
                    foundAny = true;
                }
                current = current.next;
            }

            if (!foundAny)
                Console.WriteLine("No student found with ID: " + id);
        }
        public void SearchByName(String name)
        {
            Node current = head;
            bool found = false;
            while (current != null)
            {
                if (current.data.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(current.data);
                    found = true;
                }
              current=current.next; 
            }
            if(!found)
                Console.WriteLine("No Student Found with that name");
        }

        public bool RemoveAll(int id)
        {
            bool removed = false;

            
            while (head != null && head.data.ID == id)
            {
                head = head.next;
                removed = true;
            }

            if (head == null)
            {
                tail = null;
                return removed;
            }

            Node current = head;
            while (current.next != null)
            {
                if (current.next.data.ID == id)
                {
                    current.next = current.next.next;
                    removed = true;

                    if (current.next == null) 
                        tail = current;
                }
                else
                {
                    current = current.next;
                }
            }

            return removed;
        }

        public bool Update(int id, string newName, int newAge, string newCourse, int newYear, double newGpa)
        {
            Node current = head;
            bool updated = false;

            while (current != null)
            {
                if (current.data.ID == id)
                {
                    current.data.Name = newName;
                    current.data.Age = newAge;
                    current.data.Course = newCourse;
                    current.data.YearLevel = newYear;
                    current.data.GPA = newGpa;
                    updated = true;
                }
                current = current.next;
            }

            return updated;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No student in the list.");
                return;
            }

            Node current = head;
            int recordNumber = 1;

            while (current != null)
            {
                Console.Clear();
                Console.WriteLine($"Record {recordNumber}:");
                Console.WriteLine(current.data);

                Console.WriteLine("\nPress any key to see next record...");
                Console.ReadKey();

                current = current.next;
                recordNumber++;
            }

            Console.WriteLine("\nEnd of records.");
        }
    }
}