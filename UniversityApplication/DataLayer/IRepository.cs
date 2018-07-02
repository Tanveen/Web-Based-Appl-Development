using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.DataLayer
{
    interface IRepository
    {
        void writetoCoursesTaken(string[] parts);
        void writetoStudents(string[] parts);
        void writetoCourseoffered(string[] parts);
        void writetoProfessor(string[] parts);
        void writetoDepartment(string[] parts);
        void writetoCourses(string[] parts);
        void writetoCourseprerequisites(string[] parts);
        void writetoStudentCourses(string[] parts);
        void writetoStudentMajor(string[] parts);
        void writetoProfessorDepartment(string[] parts);
        double get_grades();
        DataTable ViewCompSciStudents();
        DataTable Viewcompengrstudents();
        DataTable Viewelecengrstudents();
        DataTable Viewmathsstudents();
        DataTable Techmangstudents();
        List<CourseTaken> viewgrades();
        DataTable getsemester();
        DataTable getenrollment();
        void registercourses();
        void unregistercourses();
        DataTable fillcourses(string cmb);
    }
}