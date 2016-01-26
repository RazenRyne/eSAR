using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.Utility_Classes;
using eSAR.GradeSectionServiceRef;

namespace eSAR.Reports.GenerateTeachersLoad
{
    public partial class TeachersLoadDetails : Telerik.WinControls.UI.RadForm
    {

        public List<Teacher> teachers;

        public TeachersLoadDetails()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoadMe(object sender, EventArgs e)
        {
            //FeeServiceClient feeService = new FeeServiceClient();
            //gradeLevels = new List<GradeLevel>(feeService.GetAllGradeLevels());
            //schoolYears = new List<SchoolYear>(feeService.GetLastFiveSY());

            //cmbGradeLevel.DataSource = gradeLevels;
            //cmbGradeLevel.ValueMember = "GradeLev";
            //cmbGradeLevel.DisplayMember = "Description";

            //cmbSY.DataSource = schoolYears;
            //cmbSY.ValueMember = "SY";
            //cmbSY.DisplayMember = "SY";
            GradeSectionServiceClient gService = new GradeSectionServiceClient();
            teachers = new List<Teacher>(gService.GetAllTeachers());

            cmbTeacher.DataSource = teachers;
            cmbTeacher.ValueMember = "TeacherID";
            cmbTeacher.DisplayMember = "TeacherName";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalClass.WindowTeachersLoadDetails = false;
        }
    }
}
