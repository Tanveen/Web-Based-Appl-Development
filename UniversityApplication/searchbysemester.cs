using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApplication
{
    public partial class searchbysemester : Form
    {
        public string Semester { get; set; }
        public searchbysemester()
        {
            InitializeComponent();
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbysemester_Load(object sender, EventArgs e)
        {
            foreach (string majorstring in Enum.GetNames(typeof(CourseTaken.Semesterenum)))
            {
                cmbSemester.Items.Add(majorstring);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.Semester = cmbSemester.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
