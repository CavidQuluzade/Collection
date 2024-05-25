namespace TaskStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddGrade("Cavid", new List<int> { 100, 70, 90 });
            student.AddGrade("Cavid", new List<int> {74});
            student.AddGrade("AAA", new List<int> { 85, 79, 97, 70 });
            student.GetAllGradesByStudents("Cavid");
            student.GetAllGradesByStudents("AAA");
            student.GetAverageGrade("Cavid");
            student.GetAverageGrade("AAA");
        }
    }
}
