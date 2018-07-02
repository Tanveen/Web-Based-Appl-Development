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
    public partial class searchbyid : Form
    {
        public string StudentId { get; set; }
        public searchbyid()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.StudentId = txtStudentId.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbyid_Load(object sender, EventArgs e)
        {

        }
    }
}
