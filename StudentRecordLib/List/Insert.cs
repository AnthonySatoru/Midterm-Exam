using System;
using StudentRecordLib;

namespace StudentRecordLib.Actions
{
    public class InsertStudent : MENU
    {
        public void Execute(SinglyLinkedList list)
        {
            Console.WriteLine("\n--- Insert New Student ---");


            int id;
            while (true)
            {
                Console.Write("Enter ID: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("ID cannot be empty!");
                    continue;
                }
                if (!int.TryParse(input, out id))
                {
                    Console.WriteLine("ID must be a number!");
                    continue;
                }
                break;
            }


            string name;
            do
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Name cannot be empty!");
            } while (string.IsNullOrWhiteSpace(name));


            int age;
            while (true)
            {
                Console.Write("Enter Age: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Age cannot be empty!");
                    continue;
                }
                if (!int.TryParse(input, out age))
                {
                    Console.WriteLine("Age must be a number!");
                    continue;
                }
                if (age <= 0)
                {
                    Console.WriteLine("Age must be greater than 0!");
                    continue;
                }
                break;
            }

            string course;
            do
            {
                Console.Write("Enter Course: ");
                course = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(course))
                    Console.WriteLine("Course cannot be empty!");
            } while (string.IsNullOrWhiteSpace(course));


            int year;
            while (true)
            {
                Console.Write("Enter Year Level: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Year Level cannot be empty!");
                    continue;
                }
                if (!int.TryParse(input, out year))
                {
                    Console.WriteLine("Year Level must be a number!");
                    continue;
                }
                if (year < 1 || year > 5)
                {
                    Console.WriteLine("Year Level must be between 1 and 5!");
                    continue;
                }
                break;
            }


            double gpa;
            while (true)
            {
                Console.Write("Enter GPA (0.00 - 5.00): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("GPA cannot be empty!");
                    continue;
                }
                if (!double.TryParse(input, out gpa))
                {
                    Console.WriteLine("GPA must be a number!");
                    continue;
                }
                if (gpa < 0.0 || gpa > 5.0)
                {
                    Console.WriteLine("GPA must be between 0.00 and 5.00!");
                    continue;
                }
                break;
            }


            Student student = new Student
            {
                ID = id,
                Name = name,
                Age = age,
                Course = course,
                YearLevel = year,
                GPA = gpa
            };
            Console.WriteLine("Insert at 1-Beginning, 2-End, 3-SpecifiedPosition?");
            string pos = Console.ReadLine();
            if (pos == "1")
            {
                list.Insert(student);
            }
            else if (pos == "2")
            {
                list.InsertEnd(student);
            }
            else if (pos == "3")
            {
                Console.WriteLine("Enter position (Specified in what Position?):");
                int position = int.Parse(Console.ReadLine());
                list.InsertPosition(student, position);
                Console.WriteLine("You successfully Inserted Specified Position:");
            }
            else
            {
                Console.WriteLine("Invalid option,Student not inserted.");
            }
                
        }
    }
}