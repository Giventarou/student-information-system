using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Data;

public static class StudentSeeder
{
    public static async Task SeedAsync(ApplicationDbContext db)
    {
        if (await db.Students.AnyAsync()) return;

        db.Students.AddRange(
            new Student
            {
                NIM = "2581001",
                Name = "Michael Anderson",
                Major = "Information Systems",
                Semester = 3,
                GPA = 3.75
            },
            new Student
            {
                NIM = "2581002",
                Name = "Sarah Johnson",
                Major = "Informatics",
                Semester = 3,
                GPA = 3.88
            },
            new Student
            {
                NIM = "2581003",
                Name = "Daniel Wilson",
                Major = "Information Systems",
                Semester = 5,
                GPA = 3.42
            }
        );

        await db.SaveChangesAsync();
    }
}