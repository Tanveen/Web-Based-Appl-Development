namespace UniversityApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursePrerequisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesTakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMajorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorDepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerScienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerEngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricalEngineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technologyManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagementtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCoursesOfferedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnrollmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerForACourseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterFromACourseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgdisplay = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.studentManagementToolStripMenuItem,
            this.courseManagementtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.coursePrerequisitesToolStripMenuItem,
            this.coursesOfferedToolStripMenuItem,
            this.coursesTakenToolStripMenuItem,
            this.studentCoursesToolStripMenuItem,
            this.studentMajorsToolStripMenuItem,
            this.professorDepartmentsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "InitializeDB";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.professorsToolStripMenuItem.Text = "Professors";
            this.professorsToolStripMenuItem.Click += new System.EventHandler(this.professorsToolStripMenuItem_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // coursePrerequisitesToolStripMenuItem
            // 
            this.coursePrerequisitesToolStripMenuItem.Name = "coursePrerequisitesToolStripMenuItem";
            this.coursePrerequisitesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coursePrerequisitesToolStripMenuItem.Text = "CoursePrerequisites";
            this.coursePrerequisitesToolStripMenuItem.Click += new System.EventHandler(this.coursePrerequisitesToolStripMenuItem_Click);
            // 
            // coursesOfferedToolStripMenuItem
            // 
            this.coursesOfferedToolStripMenuItem.Name = "coursesOfferedToolStripMenuItem";
            this.coursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coursesOfferedToolStripMenuItem.Text = "CoursesOffered";
            this.coursesOfferedToolStripMenuItem.Click += new System.EventHandler(this.coursesOfferedToolStripMenuItem_Click);
            // 
            // coursesTakenToolStripMenuItem
            // 
            this.coursesTakenToolStripMenuItem.Name = "coursesTakenToolStripMenuItem";
            this.coursesTakenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coursesTakenToolStripMenuItem.Text = "CoursesTaken";
            this.coursesTakenToolStripMenuItem.Click += new System.EventHandler(this.coursesTakenToolStripMenuItem_Click);
            // 
            // studentCoursesToolStripMenuItem
            // 
            this.studentCoursesToolStripMenuItem.Name = "studentCoursesToolStripMenuItem";
            this.studentCoursesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.studentCoursesToolStripMenuItem.Text = "StudentCourses";
            this.studentCoursesToolStripMenuItem.Click += new System.EventHandler(this.studentCoursesToolStripMenuItem_Click);
            // 
            // studentMajorsToolStripMenuItem
            // 
            this.studentMajorsToolStripMenuItem.Name = "studentMajorsToolStripMenuItem";
            this.studentMajorsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.studentMajorsToolStripMenuItem.Text = "StudentMajors";
            this.studentMajorsToolStripMenuItem.Click += new System.EventHandler(this.studentMajorsToolStripMenuItem_Click);
            // 
            // professorDepartmentsToolStripMenuItem
            // 
            this.professorDepartmentsToolStripMenuItem.Name = "professorDepartmentsToolStripMenuItem";
            this.professorDepartmentsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.professorDepartmentsToolStripMenuItem.Text = "ProfessorDepartments";
            this.professorDepartmentsToolStripMenuItem.Click += new System.EventHandler(this.professorDepartmentsToolStripMenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.viewStudentGradesToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerScienceToolStripMenuItem,
            this.computerEngineeringToolStripMenuItem,
            this.electricalEngineeringToolStripMenuItem,
            this.mathsToolStripMenuItem,
            this.technologyManagementToolStripMenuItem});
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            // 
            // computerScienceToolStripMenuItem
            // 
            this.computerScienceToolStripMenuItem.Name = "computerScienceToolStripMenuItem";
            this.computerScienceToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.computerScienceToolStripMenuItem.Text = "Computer Science";
            this.computerScienceToolStripMenuItem.Click += new System.EventHandler(this.computerScienceToolStripMenuItem_Click);
            // 
            // computerEngineeringToolStripMenuItem
            // 
            this.computerEngineeringToolStripMenuItem.Name = "computerEngineeringToolStripMenuItem";
            this.computerEngineeringToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.computerEngineeringToolStripMenuItem.Text = "Computer Engineering";
            this.computerEngineeringToolStripMenuItem.Click += new System.EventHandler(this.computerEngineeringToolStripMenuItem_Click);
            // 
            // electricalEngineeringToolStripMenuItem
            // 
            this.electricalEngineeringToolStripMenuItem.Name = "electricalEngineeringToolStripMenuItem";
            this.electricalEngineeringToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.electricalEngineeringToolStripMenuItem.Text = "Electrical Engineering";
            this.electricalEngineeringToolStripMenuItem.Click += new System.EventHandler(this.electricalEngineeringToolStripMenuItem_Click);
            // 
            // mathsToolStripMenuItem
            // 
            this.mathsToolStripMenuItem.Name = "mathsToolStripMenuItem";
            this.mathsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.mathsToolStripMenuItem.Text = "Maths";
            this.mathsToolStripMenuItem.Click += new System.EventHandler(this.mathsToolStripMenuItem_Click);
            // 
            // technologyManagementToolStripMenuItem
            // 
            this.technologyManagementToolStripMenuItem.Name = "technologyManagementToolStripMenuItem";
            this.technologyManagementToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.technologyManagementToolStripMenuItem.Text = "Technology Management";
            this.technologyManagementToolStripMenuItem.Click += new System.EventHandler(this.technologyManagementToolStripMenuItem_Click);
            // 
            // viewStudentGradesToolStripMenuItem
            // 
            this.viewStudentGradesToolStripMenuItem.Name = "viewStudentGradesToolStripMenuItem";
            this.viewStudentGradesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewStudentGradesToolStripMenuItem.Text = "View Grades";
            this.viewStudentGradesToolStripMenuItem.Click += new System.EventHandler(this.viewStudentGradesToolStripMenuItem_Click);
            // 
            // courseManagementtToolStripMenuItem
            // 
            this.courseManagementtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCoursesOfferedToolStripMenuItem,
            this.viewEnrollmentsToolStripMenuItem,
            this.registerForACourseToolStripMenuItem1,
            this.unregisterFromACourseToolStripMenuItem1});
            this.courseManagementtToolStripMenuItem.Name = "courseManagementtToolStripMenuItem";
            this.courseManagementtToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.courseManagementtToolStripMenuItem.Text = "Course Management";
            // 
            // viewCoursesOfferedToolStripMenuItem
            // 
            this.viewCoursesOfferedToolStripMenuItem.Name = "viewCoursesOfferedToolStripMenuItem";
            this.viewCoursesOfferedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.viewCoursesOfferedToolStripMenuItem.Text = "View Courses Offered";
            this.viewCoursesOfferedToolStripMenuItem.Click += new System.EventHandler(this.viewCoursesOfferedToolStripMenuItem_Click_1);
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            this.viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            this.viewEnrollmentsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            this.viewEnrollmentsToolStripMenuItem.Click += new System.EventHandler(this.viewEnrollmentsToolStripMenuItem_Click);
            // 
            // registerForACourseToolStripMenuItem1
            // 
            this.registerForACourseToolStripMenuItem1.Name = "registerForACourseToolStripMenuItem1";
            this.registerForACourseToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.registerForACourseToolStripMenuItem1.Text = "Register For A Course";
            this.registerForACourseToolStripMenuItem1.Click += new System.EventHandler(this.registerForACourseToolStripMenuItem1_Click);
            // 
            // unregisterFromACourseToolStripMenuItem1
            // 
            this.unregisterFromACourseToolStripMenuItem1.Name = "unregisterFromACourseToolStripMenuItem1";
            this.unregisterFromACourseToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.unregisterFromACourseToolStripMenuItem1.Text = "Unregister From A Course";
            this.unregisterFromACourseToolStripMenuItem1.Click += new System.EventHandler(this.unregisterFromACourseToolStripMenuItem1_Click);
            // 
            // dgdisplay
            // 
            this.dgdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdisplay.Location = new System.Drawing.Point(58, 69);
            this.dgdisplay.Name = "dgdisplay";
            this.dgdisplay.Size = new System.Drawing.Size(460, 164);
            this.dgdisplay.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(631, 262);
            this.Controls.Add(this.dgdisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgdisplay;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursePrerequisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesTakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentMajorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorDepartmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagementtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCoursesOfferedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerForACourseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unregisterFromACourseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem computerScienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerEngineeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricalEngineeringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technologyManagementToolStripMenuItem;
    }
}

