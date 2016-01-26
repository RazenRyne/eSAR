using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSAR.UserServiceRef;
using System.Security.Cryptography;
using eSAR.Utility_Classes;
using eSAR.LogServiceRef;
using Newtonsoft.Json;
//using eSARDAL.Utility_Classes;

namespace eSAR.App
{
    public partial class frmLogIn : Telerik.WinControls.UI.RadForm
    {

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            UserServiceClient userService = new UserServiceClient();
            string message = String.Empty;
            if (txtPassword.Text.Equals("Enter Password")||txtPassword.Text.Equals(String.Empty) || txtUsername.Text.Equals("Enter Username")|| txtUsername.Text.Equals(String.Empty))
            {
                MessageBox.Show(this, "Username and Password is Required", "Required Fields");
                
            }
            else
            {
                if (userService.AuthenticateUser(txtUsername.Text, txtPassword.Text, ref message))
                {
                    //try
                    //{
                        eSAR.UserServiceRef.User u = new eSAR.UserServiceRef.User();
                        u = userService.GetUser(txtUsername.Text);
                        LoggedUser lu = new LoggedUser();

                        lu.UserId = u.UserId;
                        lu.UserName = u.UserName;
                        lu.LastName = u.LastName;
                        lu.FirstName = u.FirstName;
                        lu.MiddleName = u.MiddleName;
                        lu.UserType = u.UserTypeCode;

                        GlobalClass.UserLoggedIn = true;
                        GlobalClass.user = lu;
                        GlobalClass.currentsy = userService.GetCurrentSy();
                    GlobalClass.userTypeCode = lu.UserType;

                    LogServiceClient logService = new LogServiceClient();
                    string json = JsonConvert.SerializeObject(lu);
                    Log log = new Log
                    {
                        CLUD = "L",
                        LogDate = DateTime.Now,
                        TableName = "Users",
                        UserId = GlobalClass.user.UserId,
                        UserName = GlobalClass.user.UserName,
                        PassedData = json
                    };
                    logService.AddLogs(log);
                    Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    Console.WriteLine("Login Failed");
                    //}
                }
                else MessageBox.Show(this, message, "Login Failed");
                //frmLogIn FrmLogin = new frmLogIn();
                //FrmLogin.Show();
            }
            //this.Show();
            //frmLogIn FrmLogin = new frmLogIn();
            //FrmLogin.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
