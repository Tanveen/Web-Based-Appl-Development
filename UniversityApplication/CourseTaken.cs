using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    public class CourseTaken
    {
        public string StudentId { get; set; }
        public string CourseNum { get; set; }
        public string Semester { get; set; }
        public string Grade { get; set; }
        public double gpa { get; set; }

        public enum Semesterenum
        {
            Fall2016,
            Spring2017,
            Fall2017,

        }


    }
}

