using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
using eSAR.Reports.GenerateStudentPermanentRecord;
using eSARServices;
using eSARServiceInterface;
using eSARServiceModels;
using eSAR.Utility_Classes;

namespace eSAR.Admission_and_Registration
{
    public partial class frmStudentList : Telerik.WinControls.UI.RadForm
    {
        private List<string> RegisteredStudents;
        private Student studentSelected;
        private List<Student> studentList;
        public frmStudentList()
        {
            InitializeComponent();
            if (GlobalClass.userTypeCode == "cash")
            {
                this.btnRegister.Enabled = false;
                this.btnControl.Enabled = false;
                this.btnAdd.Enabled = false;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
            } else if (GlobalClass.userTypeCode == "reg")
            {
                this.btnAssess.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudentDetails fmStudentDetails = new frmStudentDetails();
            fmStudentDetails.Op = "new";
            fmStudentDetails.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvStudent.CurrentRow.Index >= 0)
            {
                frmStudentDetails fmStudentDetails = new frmStudentDetails();
                fmStudentDetails.Op = "edit";
                fmStudentDetails.SelectedStudent = studentSelected;
                fmStudentDetails.ShowDialog(this);
            }
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        public void LoadStudents()
        {
            IRegistrationService registrationService = new RegistrationService();
            RegisteredStudents= new List<string>(registrationService.GetEnrolledStudents(GlobalClass.currentsy));
            IStudentService studentService = new StudentService();
            string message = String.Empty;
            try
            {
                var students = studentService.GetAllStudents();
                studentList = new List<Student>(students);
                gvStudent.DataSource = students;
                gvStudent.Refresh();

                if (gvStudent.RowCount != 0)
                    gvStudent.Rows[0].IsSelected = true;
            }
            catch (Exception ex)
            {
                message = "Error Loading Student List";
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmStudentList_Activated(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void gvStudent_SelectionChanged(object sender, EventArgs e)
        {
            int selectedIndex = gvStudent.CurrentRow.Index;
            
            if (selectedIndex >= 0)
            {
                string sID = gvStudent.Rows[selectedIndex].Cells["StudentId"].Value.ToString();
                List<Student> item = new List<Student>();
                item = studentList.FindAll(x => x.StudentId.ToString() == sID);

                studentSelected = new Student();
                studentSelected = (Student)item[0];

            }
        }

       

        private void btnAssess_Click(object sender, EventArgs e)
        {
            if (!RegisteredStudents.Contains(studentSelected.StudentId))
                MessageBox.Show(this, "Student Should be Registered First!");
            else
            {
                AssessStudent fmAssessment = new AssessStudent();
                fmAssessment.StudentId = studentSelected.StudentId;
                fmAssessment.ShowDialog(this);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (RegisteredStudents.Contains(studentSelected.StudentId))
                  MessageBox.Show(this, "Student Already Registered!");
            else
            {
                frmStudentRegister fmStudentRegister = new frmStudentRegister();
                fmStudentRegister.StudentId = studentSelected.StudentId;
                fmStudentRegister.GradeLevel = studentSelected.GradeLevel;
                fmStudentRegister.Gender = studentSelected.Gender;
                fmStudentRegister.Show(this);
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (!RegisteredStudents.Contains(studentSelected.StudentId))
                MessageBox.Show(this, "Student Needs to be Registered First!");
             else
            {
                frmControlSubjects fmControlSubjects = new frmControlSubjects();
                fmControlSubjects.controlStudentId = studentSelected.StudentId;
                
                fmControlSubjects.ShowDialog(this);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string message = String.Empty;
            IStudentService studentService = new StudentService();
            if (studentService.DismissStudent(studentSelected.StudentId, ref message)) {
                ILogService logService = new LogService();
                studentSelected.Dismissed = true;
                string json = JsonConvert.SerializeObject(studentSelected);
                Log log = new Log
                {
                    CLUD = "D",
                    LogDate = DateTime.Now,
                    TableName = "Students",
                    UserId = GlobalClass.user.UserId,
                    UserName = GlobalClass.user.UserName,
                    PassedData = json
                };
                logService.AddLogs(log);

            }

            MessageBox.Show(this, "Student Dismissed");
                        
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (studentSelected != null)
            {
                GeneratePermanentRec gpr = new GeneratePermanentRec();
                gpr._studentID = studentSelected.StudentId;
                gpr.Show();
            }
        }

     
    }
}
