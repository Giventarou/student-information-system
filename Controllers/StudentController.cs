// Name: Given Asser Sianturi
// NIM: 2481012
// Course: Framework .NET Programming

using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Data;
using StudentInformationSystem.Models;

namespace StudentInformationSystem.Controllers
{
    // Handles requests for student web pages.
    public class StudentController : Controller
    {
        // Displays the first student's profile.
        public IActionResult Profile()
        {
            // Retrieve the first student from shared data.
            Student student = StudentData.Students[0];

            // Send the Student object to the Razor View.
            return View(student);
        }
    }
}