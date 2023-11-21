namespace _42.Students
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }
            
            public string HomeTown { get; set; }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string[] studentsInputInformation = Console.ReadLine().Split().ToArray();

            string checkEnd = studentsInputInformation[0];

            while (checkEnd != "end")
            {
                string studentFirstName = studentsInputInformation[0];
                string studentLastName = studentsInputInformation[1];
                int studentAge = int.Parse(studentsInputInformation[2]);
                string studentHomeTown = studentsInputInformation[3];

                Student student = new Student
                {
                    FirstName = studentFirstName,
                    LastName = studentLastName,
                    Age = studentAge,
                    HomeTown = studentHomeTown,
                };

                students.Add(student);

                studentsInputInformation = Console.ReadLine().Split().ToArray();

                checkEnd = studentsInputInformation[0];
            }
            
            string cityName = Console.ReadLine();

            List<Student> filteredStudents = students
                                            .Where(x => x.HomeTown == cityName)
                                            .ToList();

            foreach (var currentFilteredStudent in filteredStudents)
            {
                Console.WriteLine($"{currentFilteredStudent.FirstName} {currentFilteredStudent.LastName} is {currentFilteredStudent.Age} years old.");
            }
        }
    }
}