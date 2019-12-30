using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem_v0._CRUD_Operations;

namespace StudentManagementSystem_v0._UserControls
{
    public partial class ucCheckResult : UserControl
    {
        MarksEntryCRUD marksEntryCRUD = MarksEntryCRUD.getMarksEntryCRUD;
        public ucCheckResult()
        {
            InitializeComponent();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var course = cbCourse.SelectedItem as Course;
                dgvResult.DataSource = null;         
                dgvResult.DataSource = marksEntryCRUD.GetEntries(int.Parse(txtSID.Text), course.CourseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
