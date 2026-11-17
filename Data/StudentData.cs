// Name: Given Asser Sianturi
// NIM: 2481012
// Course: Framework .NET Programming

using StudentInformationSystem.Models;

namespace StudentInformationSystem.Data
{
    // Provides sample student information.
    // Both MVC and API controllers will use this data.
    public static class StudentData
    {
        // In-memory collection of students.
        public static readonly List<Student> Students = new()
        {
            new Student
            {
                NIM = "2481012",
                Name = "Given Asser Sianturi",
                Major = "Informatics Engineering",
                Semester = 5,
                GPA = 3.71
            },
            new Student
            {
                NIM = "2481049",
                Name = "Jefri Rialdi Simbolon",
                Major = "Informatics Engineering",
                Semester = 5,
                GPA = 3.49
            },
            new Student
            {
                NIM = "2581027",
                Name = "Friendly Harold Panjaitan",
                Major = "Information Systems",
                Semester = 3,
                GPA = 3.38
            }
        };
    }
}