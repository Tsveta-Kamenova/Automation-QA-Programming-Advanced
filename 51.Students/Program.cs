namespace _51.Students
{
    public class Program
    {
        //public class Student
        //{
        //    public Student(string firstName, string lastName, double grade)
        //    {
        //        FirstName = firstName;
        //        LastName = lastName;
        //        Grade = grade;
        //    }

        //    public string FirstName { get; set; }

        //    public string LastName { get; set; }

        //    public double Grade { get; set; }

        //    public void PrintStudent()
        //    {
        //        Console.WriteLine($"{FirstName} {LastName}: {Grade:F2}");
        //    }
        //}

        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInformation = Console.ReadLine().Split().ToArray();

                string currentFirstName = studentInformation[0];
                string currentLastName = studentInformation[1];
                double currentGrade = double.Parse(studentInformation[2]);

                Student currentStudent = new Student(currentFirstName, currentLastName, currentGrade );

                students.Add(currentStudent);
            }

            List<Student> orderedStudents = students
                .OrderByDescending(student => student.Grade)
                .ToList();

            foreach (Student student in orderedStudents)
            {
                student.PrintStudent();
            }
        }
    }
}