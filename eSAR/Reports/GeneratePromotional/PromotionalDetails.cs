using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.Utility_Classes;
using eSAR.FeeServiceRef;
using eSAR.ScheduleServiceRef;
using eSAR.Reports.GenerateProspectus;

namespace eSAR.Reports.GeneratePromotional
{
    public partial class PromotionalDetails : Telerik.WinControls.UI.RadForm
    {
        public List<FeeServiceRef.SchoolYear> schoolYears;
        public List<ScheduleServiceRef.GradeLevel> gradeLevels;
        public List<GradeSection> sections;
        public string gradelevel;


        public PromotionalDetails()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnCancelScholarshipDiscount_Click(object sender, EventArgs e)
        {
            this.Close();
            GlobalClass.WindowProspectusDetails = false;
        }

        private void LoadMe(object sender, EventArgs e)
        {
            SubjectAssignmentServiceClient subjectAss = new SubjectAssignmentServiceClient();
            FeeServiceClient feeSer = new FeeServiceClient();

            gradeLevels = new List<ScheduleServiceRef.GradeLevel>(subjectAss.GetAllGradeLevels());
            schoolYears = new List<FeeServiceRef.SchoolYear>(feeSer.GetLastFiveSY());
            sections = new List<GradeSection>(subjectAss.GetAllSections());

            cmbGradeLevel.DataSource = gradeLevels;
            cmbGradeLevel.ValueMember = "GradeLev";
            cmbGradeLevel.DisplayMember = "Description";

            cmbSY.DataSource = schoolYears;
            cmbSY.ValueMember = "SY";
            cmbSY.DisplayMember = "SY";
            
        }

        private void cmbGradeLevel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbGradeLevel.SelectedIndex != -1)
            {
                gradelevel = cmbGradeLevel.SelectedValue.ToString();
                List<GradeSection> gs = new List<GradeSection>();
                List<Subject> sub = new List<Subject>();

                gs = sections.FindAll(s => s.GradeLevel == gradelevel);
                
                cmbSection.DataSource = gs;
                cmbSection.ValueMember = "GradeSectionCode";
                cmbSection.DisplayMember = "Section";

                if (gs.Count <= 0)
                {
                    cmbSection.Text = string.Empty;
                    cmbSection.Enabled = false;
                    return;
                }
                else
                {
                    cmbSection.Enabled = true;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
