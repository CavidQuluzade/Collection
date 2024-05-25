using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskStudent
{
    internal class Student
    {
        Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
        public Student()
        {
            students = new Dictionary<string, List<int>>();
        }
        public void AddGrade(string studentName, List<int> grades)
        {
            if (!students.ContainsKey(studentName))
                students[studentName] = grades;
            else
                students[studentName].AddRange(grades);
        }
        public void RemoveStudent(string studentName)
        {
            students.Remove(studentName);
        }
        public void GetAllGradesByStudents(string studentName)
        {
            Console.WriteLine(studentName + " grades:");
            foreach (var grade in students[studentName])
            {
                Console.WriteLine(grade);
            }
        }
        public void GetAverageGrade(string studentName)
        {
            double sum = 0;
            double average = 0;
            foreach(var grade in students[studentName])
            {
                sum += grade;
                
            }
            average = sum / students[studentName].Count;
            Console.WriteLine(studentName + " average is: " + average);
        }
    }
}
