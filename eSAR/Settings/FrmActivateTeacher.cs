using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Newtonsoft.Json;
using eSAR.Utility_Classes;
using eSARServices;
using eSARServiceInterface;
using eSARServiceModels;
namespace eSAR.Settings
{

    public partial class FrmActivateTeacher : Telerik.WinControls.UI.RadForm
    {
        private Teacher teacher = new Teacher();
        ITeacherService teachService = new TeacherService();
        public FrmActivateTeacher()
        {
            InitializeComponent();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            Boolean activated = false;
            activated = teachService.ActivateTeacher(txtFName.Text, txtMName.Text, txtLName.Text);
            if (activated)
            {
                MessageBox.Show("Teacher Successfully Activated");
                this.Close();
            }
            else {
                MessageBox.Show("Teacher Does Not Exist");
                this.txtFName.Text = " ";
                this.txtMName.Text = " ";
                this.txtLName.Text = " ";
            }
          
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
