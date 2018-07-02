using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApplication.BusinessLayer;

namespace UniversityApplication
{
    public partial class Form1 : Form
    {
        IBusiness ibus = null;
        public Form1()
        {
            InitializeComponent();
            ibus = new Business();
        }

      
        

        private void studentCoursesToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "StudentCourses");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void coursesTakenToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "CoursesTaken");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "Students");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "Departments");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void professorsToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "Professors");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "Courses");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void coursePrerequisitesToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "CoursePrerequisites");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void coursesOfferedToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "CoursesOffered");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void studentMajorsToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "StudentMajors");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }

        private void professorDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
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

                        ibus.writetodb(parts, "ProfessorDepartments");
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
            MessageBox.Show("StudentCourses table has been updated successfully");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CourseTaken> newlist = ibus.grades();
            dgdisplay.DataSource = newlist;
            dgdisplay.Refresh();
        }



        private void computerScienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.CompSciStudents();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();

        }

        private void computerEngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.CompengrStudents();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();

        }

        private void electricalEngineeringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.elecengrStudents();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();
        }

        private void mathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.mathsStudents();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();
        }

        private void technologyManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.techmangStudents();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();

        }

        private void viewCoursesOfferedToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ibus.semester();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();
        }

        private void viewEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = ibus.enrollment();
            dgdisplay.DataSource = dt;
            dgdisplay.Refresh();
        }

        private void registerForACourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ibus.registerforcourses();
            MessageBox.Show("Registration Successful");
            }

        private void unregisterFromACourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ibus.unregisterforcourses();
           // MessageBox.Show("You have been unregisterd from this course");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
   













