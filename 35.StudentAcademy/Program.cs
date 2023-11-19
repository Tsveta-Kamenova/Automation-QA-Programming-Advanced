namespace _5._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new();

            int studentsCount = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(studentName))
                {
                    studentGrades[studentName].Add(studentGrade);
                }
                else
                {
                    studentGrades[studentName] = new() { studentGrade };
                }
            }
            
            var excellents = studentGrades.Where(st => st.Value.Average() >= 4.50);
            
            foreach (var item in excellents)
            {
                double currentAverageGrade = item.Value.Average(); ;
                Console.WriteLine($"{item.Key} -> {currentAverageGrade:F2}");
            }
        }
    }
}