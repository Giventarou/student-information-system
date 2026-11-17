// Name: Given Asser Sianturi
// NIM: 2481012
// Course: Framework .NET Programming

namespace StudentInformationSystem.Models
{
    public class Student
    {
        //Declaring every Getter and Setter
        //Structure of Student
        /*
         * NIM
         * Name
         * Major
         * Semester
         * GPA  
         */
        public string NIM { get; set; } = "";
        public string Name { get; set; } = "";
        public string Major { get; set; } = "";
        public int Semester { get; set; }
        public double GPA { get; set; }



    }
}
