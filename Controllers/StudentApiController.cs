// Name: Given Asser Sianturi
// NIM: 2481012
// Course: Framework .NET Programming

using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Data;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Controllers
{
    // Indicates that this controller provides API endpoints.
    [ApiController]
    // Defines the base URL for this API.
    [Route("api/students")]
    public class StudentsApiController : ControllerBase
    {
        // GET: /api/students
        // Returns all students as JSON.
        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            // Retrieve all students from shared data.
            List<Student> students = StudentData.Students;

            // Return HTTP 200 OK with the student list.
            return Ok(students);
        }

        // GET: /api/students/2581001
        // Returns a student based on NIM.
        [HttpGet("{nim}")]
        public ActionResult<Student> GetStudentByNIM(string nim)
        {
            // Search for a matching student.
            Student? student = StudentData.Students
                .FirstOrDefault(s => s.NIM == nim);

            // Return HTTP 404 if no student is found.
            if (student == null)
            {
                return NotFound(
                    new { message = "Student not found." }
                );
            }

            // Return HTTP 200 with student information.
            return Ok(student);
        }
    }
}