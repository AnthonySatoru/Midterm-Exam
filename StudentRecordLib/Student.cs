namespace StudentRecordLib
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public int YearLevel { get; set; }
        public double GPA { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}, Course: {Course}, Year: {YearLevel}, GPA: {GPA}";
        }
    }
}