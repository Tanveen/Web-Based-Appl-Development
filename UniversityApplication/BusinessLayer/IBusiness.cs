using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApplication.BusinessLayer
{
   public interface IBusiness
    {
        void writetodb(string[] parts, string table);
        void get_grades();
        DataTable CompSciStudents();
        DataTable CompengrStudents();
        DataTable elecengrStudents();
        DataTable mathsStudents();
        DataTable techmangStudents();
        List<CourseTaken> grades();

        DataTable semester();
        DataTable enrollment();
        void unregisterforcourses();
        void registerforcourses();

    }
}
