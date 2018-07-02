using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApplication;

namespace UniversityApplication.DataLayer
{
    class Repository : IRepository
    {
        IDataAccess idac = null;
        public Repository()
        {
            idac = new DataAccess();
        }

        public void writetoCourseoffered(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO CoursesOffered(CourseNum, Semester, MaxEnrollment, EnrolledCount, RoomNumber, ProfessorId) VALUES(@CourseNum, @Semester, @MaxEnrollment, @EnrolledCount, @RoomNumber, @ProfessorId)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                SqlParameter p2 = new SqlParameter("@Semester", SqlDbType.VarChar, 20);
                SqlParameter p3 = new SqlParameter("@MaxEnrollment", SqlDbType.Int);
                SqlParameter p4 = new SqlParameter("@EnrolledCount", SqlDbType.Int);
                SqlParameter p5 = new SqlParameter("@RoomNumber", SqlDbType.VarChar, 20);
                SqlParameter p6 = new SqlParameter("@ProfessorId", SqlDbType.Int);

                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                p4.Value = parts[3];
                p5.Value = parts[4];
                p6.Value = parts[5];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                newlist.Add(p5);
                newlist.Add(p6);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoCourseprerequisites(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO CoursePrerequisites(CourseNum, PrereqCourseNum) VALUES (@CourseNum, @PrereqCourseNum)";
                List<DbParameter> newlist = new List<DbParameter>();

                SqlParameter p1 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                SqlParameter p2 = new SqlParameter("@PrereqCourseNum", SqlDbType.VarChar, 20);

                p1.Value = parts[0];
                p2.Value = parts[1];

                newlist.Add(p1);
                newlist.Add(p2);

                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoCourses(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO Courses(CourseNum, CourseName, CreditHours, Description, DepartmentId) VALUES (@CourseNum, @CourseName, @CreditHours, @Description, @DepartmentId)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                SqlParameter p2 = new SqlParameter("@CourseName", SqlDbType.VarChar, 50);
                SqlParameter p3 = new SqlParameter("@CreditHours", SqlDbType.Int);
                SqlParameter p4 = new SqlParameter("@Description", SqlDbType.Text);
                SqlParameter p5 = new SqlParameter("@DepartmentId", SqlDbType.Int);
                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                p4.Value = parts[3];
                p5.Value = parts[4];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                newlist.Add(p5);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoCoursesTaken(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO CoursesTaken(StudentId, CourseNum, Semester, Grade) VALUES (@StudentId, @CourseNum, @Semester, @Grade)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 10);
                SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 30);
                SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar, 20);
                SqlParameter p4 = new SqlParameter("@Grade", SqlDbType.VarChar, 2);
                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                p4.Value = parts[3];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoDepartment(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO Departments(DepartmentId, DepartmentName) VALUES (@DepartmentId, @DepartmentName)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@DepartmentId", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@DepartmentName", SqlDbType.VarChar, 20);

                p1.Value = parts[0];
                p2.Value = parts[1];

                newlist.Add(p1);
                newlist.Add(p2);

                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoProfessor(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO Professors(ProfessorId, Firstname, LastName, StreetAddress, City, State, Telephone) VALUES (@professorId, @FirstName, @LastName, @StreetAddress, @City, @State, @Telephone)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@ProfessorId", SqlDbType.VarChar, 10);
                SqlParameter p2 = new SqlParameter("@Firstname", SqlDbType.VarChar, 50);
                SqlParameter p3 = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
                SqlParameter p4 = new SqlParameter("@StreetAddress", SqlDbType.VarChar, 100);
                SqlParameter p5 = new SqlParameter("@City", SqlDbType.VarChar, 50);
                SqlParameter p6 = new SqlParameter("@State", SqlDbType.VarChar, 10);
                SqlParameter p7 = new SqlParameter("@Telephone", SqlDbType.VarChar, 20);
                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                p4.Value = parts[3];
                p5.Value = parts[4];
                p6.Value = parts[5];
                p7.Value = parts[6];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                newlist.Add(p5);
                newlist.Add(p6);
                newlist.Add(p7);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoProfessorDepartment(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO ProfessorDepartments(ProfessorId, DepartmentId) VALUES (@ProfessorId, @DepartmentId)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@ProfessorId", SqlDbType.Int);
                SqlParameter p2 = new SqlParameter("@DepartmentId", SqlDbType.Int);

                p1.Value = parts[0];
                p2.Value = parts[1];

                newlist.Add(p1);
                newlist.Add(p2);

                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoStudentCourses(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO StudentCourses(StudentId, CourseNum, Semester) VALUES (@StudentId, @CourseNum, @Semester)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 10);
                SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar, 20);
                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoStudentMajor(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO StudentMajors(StudentId, DepartmentId) VALUES (@StudentId, @DepartmentId)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 20);
                SqlParameter p2 = new SqlParameter("@DepartmentId", SqlDbType.Int);

                p1.Value = parts[0];
                p2.Value = parts[1];

                newlist.Add(p1);
                newlist.Add(p2);

                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void writetoStudents(string[] parts)
        {
            try
            {
                string sql = "INSERT INTO Students(StudentId, Firstname, LastName, StreetAddress, City, State, Telephone) VALUES (@Studentid, @FirstName, @LastName, @StreetAddress, @City, @State, @Telephone)";
                List<DbParameter> newlist = new List<DbParameter>();
                SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 10);
                SqlParameter p2 = new SqlParameter("@Firstname", SqlDbType.VarChar, 50);
                SqlParameter p3 = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
                SqlParameter p4 = new SqlParameter("@StreetAddress", SqlDbType.VarChar, 100);
                SqlParameter p5 = new SqlParameter("@City", SqlDbType.VarChar, 50);
                SqlParameter p6 = new SqlParameter("@State", SqlDbType.VarChar, 10);
                SqlParameter p7 = new SqlParameter("@Telephone", SqlDbType.VarChar, 20);
                p1.Value = parts[0];
                p2.Value = parts[1];
                p3.Value = parts[2];
                p4.Value = parts[3];
                p5.Value = parts[4];
                p6.Value = parts[5];
                p7.Value = parts[6];
                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                newlist.Add(p5);
                newlist.Add(p6);
                newlist.Add(p7);
                idac.InsertUpdateDelete(sql, newlist);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public double get_grades()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            searchbyid fm1 = new searchbyid();
            double sum = 0;

            string sql = "select Grade from CoursesTaken where StudentId ='" + fm1.StudentId + "'";
            char[] seps = { ',' };
            string[] parts = sql.Split(seps);
            SqlParameter p1 = new SqlParameter("@Grade", parts[0]);
            newlist.Add(p1);
            DataTable dt = idac.GetManyRowsCols(sql, newlist);
            int count = dt.Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string g = dt.Rows[i]["Grade"].ToString();
                if (g == "A")
                    sum += 4.0;
                else if (g == "A-")
                    sum += 3.8;
                else if (g == "B+")
                    sum += 3.6;
                else if (g == "B")
                    sum += 3.5;
                else if (g == "B-")
                    sum += 3.4;
                else if (g == "C+")
                    sum += 3.2;
                else if (g == "C")
                    sum += 3.1;
                else if (g == "C-")
                    sum += 3.0;
                else if (g == "D")
                    sum += 2.5;
                else
                    sum += 0;
            }
            double gpa = sum / 12;
            return gpa;
        }
        

        public DataTable ViewCompSciStudents()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            DataTable dt = null;
            try
            {
                string sql = "select S.StudentId, S.FirstName, S.LastName, D.DepartmentName, SM.DepartmentId from Departments D inner join StudentMajors SM on D.DepartmentId = SM.DepartmentId inner join Students S  on SM.StudentId = S.StudentId where D.DepartmentName = 'Computer Science'";
                char[] seps = { ',' };
                string[] parts = sql.Split(seps);
                SqlParameter p1 = new SqlParameter("@StudentId", parts[0]);
                SqlParameter p2 = new SqlParameter("@Firstname", parts[1]);
                SqlParameter p3 = new SqlParameter("@DepartmentName", parts[2]);
                SqlParameter p4 = new SqlParameter("@DepartmentId", parts[3]);

                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                dt = idac.GetManyRowsCols(sql, newlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable Viewcompengrstudents()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            DataTable dt = null;
            try
            {
                string sql = "select S.StudentId, S.FirstName, S.LastName, D.DepartmentName, SM.DepartmentId from Departments D inner join StudentMajors SM on D.DepartmentId = SM.DepartmentId inner join Students S  on SM.StudentId = S.StudentId where D.DepartmentName = 'Computer Engineering'";
                char[] seps = { ',' };
                string[] parts = sql.Split(seps);
                SqlParameter p1 = new SqlParameter("@StudentId", parts[0]);
                SqlParameter p2 = new SqlParameter("@Firstname", parts[1]);
                SqlParameter p3 = new SqlParameter("@DepartmentName", parts[2]);
                SqlParameter p4 = new SqlParameter("@DepartmentId", parts[3]);

                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                dt = idac.GetManyRowsCols(sql, newlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable Viewelecengrstudents()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            DataTable dt = null;
            try
            {
                string sql = "select S.StudentId, S.FirstName, S.LastName, D.DepartmentName, SM.DepartmentId from Departments D inner join StudentMajors SM on D.DepartmentId = SM.DepartmentId inner join Students S  on SM.StudentId = S.StudentId where D.DepartmentName = 'Elec Engieering'";
                char[] seps = { ',' };
                string[] parts = sql.Split(seps);
                SqlParameter p1 = new SqlParameter("@StudentId", parts[0]);
                SqlParameter p2 = new SqlParameter("@Firstname", parts[1]);
                SqlParameter p3 = new SqlParameter("@DepartmentName", parts[2]);
                SqlParameter p4 = new SqlParameter("@DepartmentId", parts[3]);

                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                dt = idac.GetManyRowsCols(sql, newlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable Viewmathsstudents()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            DataTable dt = null;
            try
            {
                string sql = "select S.StudentId, S.FirstName, S.LastName, D.DepartmentName, SM.DepartmentId from Departments D inner join StudentMajors SM on D.DepartmentId = SM.DepartmentId inner join Students S  on SM.StudentId = S.StudentId where D.DepartmentName = 'Math'";
                char[] seps = { ',' };
                string[] parts = sql.Split(seps);
                SqlParameter p1 = new SqlParameter("@StudentId", parts[0]);
                SqlParameter p2 = new SqlParameter("@Firstname", parts[1]);
                SqlParameter p3 = new SqlParameter("@DepartmentName", parts[2]);
                SqlParameter p4 = new SqlParameter("@DepartmentId", parts[3]);

                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                dt = idac.GetManyRowsCols(sql, newlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable Techmangstudents()
        {
            List<DbParameter> newlist = new List<DbParameter>();
            DataTable dt = null;
            try
            {
                string sql = "select S.StudentId, S.FirstName, S.LastName, D.DepartmentName, SM.DepartmentId from Departments D inner join StudentMajors SM on D.DepartmentId = SM.DepartmentId inner join Students S  on SM.StudentId = S.StudentId where D.DepartmentName = 'Tech Management'";
                char[] seps = { ',' };
                string[] parts = sql.Split(seps);
                SqlParameter p1 = new SqlParameter("@StudentId", parts[0]);
                SqlParameter p2 = new SqlParameter("@Firstname", parts[1]);
                SqlParameter p3 = new SqlParameter("@DepartmentName", parts[2]);
                SqlParameter p4 = new SqlParameter("@DepartmentId", parts[3]);

                newlist.Add(p1);
                newlist.Add(p2);
                newlist.Add(p3);
                newlist.Add(p4);
                dt = idac.GetManyRowsCols(sql, newlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }


        public List<CourseTaken> viewgrades()
        {
            
            List<CourseTaken> list = new List<CourseTaken>();
            searchbyid fm1 = new searchbyid();
            if (fm1.ShowDialog() == DialogResult.OK)
            {
                List<DbParameter> newlist = new List<DbParameter>();
                DataTable dt = null;
                string sql = "select CourseNum, Grade from CoursesTaken where StudentId ='" + fm1.StudentId + "'";
                dt = idac.GetManyRowsCols(sql, newlist);
                List<double> glist = new List<double>();
                double sum;
                foreach (DataRow drow in dt.Rows)
                {
                    string g = drow["Grade"].ToString();
                    if (g == "A")
                        sum = 4.0;
                    else if (g == "A-")
                        sum = 3.8;
                    else if (g == "B+")
                        sum = 3.6;
                    else if (g == "B")
                        sum = 3.5;
                    else if (g == "B-")
                        sum = 3.4;
                    else if (g == "C+")
                        sum = 3.2;
                    else if (g == "C")
                        sum = 3.1;
                    else if (g == "C-")
                        sum = 3.0;
                    else if (g == "D")
                        sum = 2.5;
                    else
                        sum = 0;

                    glist.Add(sum);
                }

                double avg = glist.Average();
                foreach (DataRow drow in dt.Rows)
                {
                    CourseTaken ct = new CourseTaken();
                    ct.CourseNum = drow["CourseNum"].ToString();
                    ct.Grade = drow["Grade"].ToString();
                    ct.gpa = avg;
                    list.Add(ct);
                }
            }
            return list;
        }


        public DataTable getsemester()
        {
            DataTable dt = null;
            searchbysemester fm1 = new searchbysemester();
            if (fm1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<DbParameter> newlist = new List<DbParameter>();
                    string sql = "select CourseNum from CoursesOffered where Semester ='" + fm1.Semester + "'";
                    char[] seps = { ',' };
                    string[] parts = sql.Split(seps);
                    SqlParameter p1 = new SqlParameter("@CourseNum", parts[0]);
                    newlist.Add(p1);
                    dt = idac.GetManyRowsCols(sql, newlist);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }

        public DataTable getenrollment()
        {
            DataTable dt = null;
            searchenrollment fm1 = new searchenrollment();
            if (fm1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<DbParameter> newlist = new List<DbParameter>();
                    string sql = "select * from CoursesOffered where CourseNum ='" + fm1.Coursenum + "'";
                    char[] seps = { ',' };
                    string[] parts = sql.Split(seps);
                    SqlParameter p1 = new SqlParameter("@CourseNum", parts[0]);
                    SqlParameter p2 = new SqlParameter("@Semester", parts[1]);
                    SqlParameter p3 = new SqlParameter("@MaxEnrollment", parts[2]);
                    SqlParameter p4 = new SqlParameter("@EnrolledCount", parts[3]);
                    SqlParameter p5 = new SqlParameter("@RoomNumber", parts[4]);
                    SqlParameter p6 = new SqlParameter("@ProfessorId", parts[5]);

                    newlist.Add(p1);
                    newlist.Add(p2);
                    newlist.Add(p3);
                    newlist.Add(p4);
                    newlist.Add(p5);
                    newlist.Add(p6);
                    dt = idac.GetManyRowsCols(sql, newlist);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return dt;
        }


        public void registercourses()
        {
            Registercourses fm1 = new Registercourses();
            if (fm1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sql = "INSERT INTO StudentCourses(StudentId, CourseNum, Semester) VALUES('" + fm1.StudentId + "', '" + fm1.Coursenum + "', '" + fm1.Semester + "')";
                    List<DbParameter> newlist = new List<DbParameter>();
                    char[] seps = { ',' };
                    string[] parts = sql.Split(seps);
                    SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 10);
                    SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                    SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar, 20);
                    p1.Value = parts[0];
                    p2.Value = parts[1];
                    p3.Value = parts[2];
                    newlist.Add(p1);
                    newlist.Add(p2);
                    newlist.Add(p3);
                    idac.InsertUpdateDelete(sql, newlist);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }



        public void unregistercourses()
        {
            Unregister fm1 = new Unregister();
            if (fm1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sql = ("DELETE FROM StudentCourses where StudentId = '" + fm1.StudentId + "' and CourseNum = '" + fm1.Coursenum + "'and semester = '" + fm1.Semester +"'");
                    List<DbParameter> newlist = new List<DbParameter>();
                    char[] seps = { ',' };
                    string[] parts = sql.Split(seps);
                    SqlParameter p1 = new SqlParameter("@StudentId", SqlDbType.VarChar, 10);
                    SqlParameter p2 = new SqlParameter("@CourseNum", SqlDbType.VarChar, 20);
                    SqlParameter p3 = new SqlParameter("@Semester", SqlDbType.VarChar, 20);
                    p1.Value = parts[0];
                    p2.Value = parts[1];
                    p3.Value = parts[2];
                    newlist.Add(p1);
                    newlist.Add(p2);
                    newlist.Add(p3);
                  int x =  idac.InsertUpdateDelete(sql, newlist);
                    MessageBox.Show("You have been unregisterd from this course");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    
        public DataTable fillcourses(string cmb)
        {
            string sem_selected = cmb;
           
            List<DbParameter> newlist = new List<DbParameter>();
            string sql = "select CourseNum from CoursesOffered where Semester ='" + sem_selected + "'";
            char[] seps = { ',' };
            string[] parts = sql.Split(seps);
            SqlParameter p1 = new SqlParameter("@CourseNum", parts[0]);
            newlist.Add(p1);
            DataTable dt = idac.GetManyRowsCols(sql, newlist);
            return dt;
        }

    }
}


