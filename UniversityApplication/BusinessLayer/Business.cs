using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApplication.DataLayer;

namespace UniversityApplication.BusinessLayer
{
    class Business: IBusiness
    {
        IRepository irep = null;
        public Business()
        {
            irep = new Repository();
        }



        public void writetodb(string[] parts, string table)
        {
            switch (table)
            {
                case "CoursesTaken":
                    irep.writetoCoursesTaken(parts);
                    break;
                case "CoursesOffered":
                    irep.writetoCourseoffered(parts);
                    break;
                case "CoursePrerequisites":
                    irep.writetoCourseprerequisites(parts);
                    break;
                case "Courses":
                    irep.writetoCourses(parts);
                    break;
                case "Departments":
                    irep.writetoDepartment(parts);
                    break;
                case "Professors":
                    irep.writetoProfessor(parts);
                    break;
                case "ProfessorDepartments":
                    irep.writetoProfessorDepartment(parts);
                    break;
                case "StudentCourses":
                    irep.writetoStudentCourses(parts);
                    break;
                case "StudentMajors":
                    irep.writetoStudentMajor(parts);
                    break;
                case "Students":
                    irep.writetoStudents(parts);
                    break;

            }
           
        }

        void IBusiness.get_grades()
        {
            irep.get_grades();
        }

        public  DataTable CompSciStudents()
        {
            
            DataTable dt = irep.ViewCompSciStudents();
            return dt;
        }

        
public DataTable CompengrStudents()
        {
            DataTable dt = irep.Viewcompengrstudents();
            return dt;
           
        }

        public DataTable elecengrStudents()
        {
            DataTable dt = irep.Viewelecengrstudents();
            return dt;
        }

        public DataTable mathsStudents()  
            {
                DataTable dt = irep.Viewmathsstudents();
            return dt;
            }
        public DataTable techmangStudents()
        {
            DataTable dt = irep.Techmangstudents();
            return dt;
        }

       

        List<CourseTaken> IBusiness.grades()
        {
            List<CourseTaken> newlist = irep.viewgrades();
            return newlist;
        }

        public DataTable semester() {
            DataTable dt = irep.getsemester();
            return dt;
        }

        public DataTable enrollment()
        {
            DataTable dt = irep.getenrollment();
            return dt;
        }

        public void registerforcourses()
        {
            irep.registercourses();


        }

        public void unregisterforcourses()
        {
            irep.unregistercourses();


        }



    }
}
