using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;

namespace StudentInformationSystem.Controllers;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _db;

    public StudentController(ApplicationDbContext db) => _db = db;

    public async Task<IActionResult> Profile(string? nim)
    {
        var student = string.IsNullOrWhiteSpace(nim)
            ? await _db.Students.AsNoTracking().OrderBy(s => s.Id).FirstOrDefaultAsync()
            : await _db.Students.AsNoTracking().FirstOrDefaultAsync(s => s.NIM == nim);

        return student is null ? NotFound() : View(student);
    }
}