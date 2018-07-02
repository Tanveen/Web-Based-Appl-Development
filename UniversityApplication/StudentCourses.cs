using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    class StudentCourses
    {
        public string StudentId { get; set; }
        public string CourseNum { get; set; }
        public string Semester { get; set; }


        public static void writetodb(string[] parts)
        {
            string connstr = @"Server = Grace-PC;Integrated Security =true; database = UBDB";
            SqlConnection con = new SqlConnection(connstr);
            con.Open();
            try
            {                SqlCommand cmd = new SqlCommand("INSERT INTO StudentCourses(StudentId, CourseNum, Semester) VALUES (@StudentId, @CourseNum, @Semester)", con);
                cmd.Parameters.AddWithValue("@StudentId", parts[0]);
                cmd.Parameters.AddWithValue("@CourseNum", parts[1]);

                cmd.Parameters.AddWithValue("@Semester", parts[2]);

                cmd.ExecuteNonQuery();                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }        public static void Readstudentcourses()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:\\temp";
                ofd.Filter = "text files|*.txt|docx files|*.doc";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    FileInfo fi = new FileInfo(filename);

                    Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                    StreamReader sstr = new StreamReader(str);

                    string sLine;
                    char[] seps = { ',' };


                    while ((sLine = sstr.ReadLine()) != null)
                    {
                        string[] parts = sLine.Split(seps);

                        writetodb(parts);
                        if (sLine == null)
                            break;
                        if (sLine.Trim() == "")
                            break;
                    }
                    sstr.Close();
                    str.Close();
                }
            }
            catch (FileNotFoundException fe)
            {

                MessageBox.Show("FE:" + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX:" + ex.Message + "\n" +
                    ex.StackTrace);
            }

        }

    }
}
