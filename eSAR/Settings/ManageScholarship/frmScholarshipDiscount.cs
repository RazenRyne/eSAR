using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
//using eSAR.FeeServiceRef;
using eSAR.ScholarshipServiceRef;

namespace eSAR.Settings.ManageScholarship
{
    public partial class frmScholarshipDiscount : Telerik.WinControls.UI.RadForm
    {
        public string Op { get; set; }
        public string feeCode { get; set; }
        public string scholarshipCode { get; set; }
     //   public List<Fee> fee;
        public List<ScholarshipDiscount> sd { get; set; }

        public frmScholarshipDiscount()
        {
            InitializeComponent();
        }

        private void frmScholarshipDiscount_Load(object sender, EventArgs e)
        {
            if (Op.Equals("newScholarshipDiscount"))
            {
                txtCode.Text = scholarshipCode.ToString();
                txtCode.Enabled = false;

                ScholarshipServiceClient fSC = new ScholarshipServiceClient();
               // fee = new List<Fee>(fSC.GetAllFees());

            //    cmbFee.DataSource = fee;
                cmbFee.ValueMember = "FeeID";
                cmbFee.DisplayMember = "FeeDescription";
            }
        }

        private void btnSaveScholarshipDiscount_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            //ScholarshipServiceClient scholarshipService = new ScholarshipServiceClient();
            //Boolean ret = false;
            //string message = String.Empty;
            //string ScholarshipCodeString = String.Empty;
            //string temp = String.Empty;
            //int index = 2;
            //temp = (cmbFee.SelectedValue.ToString());
            //int feeID = Int32.Parse(temp);

            frmScholarshipDetails fmScholarshipDetails = new frmScholarshipDetails();

            //Fee feeID = (Fee) (cmbFee.SelectedValue);
            double dis = double.Parse(txtDiscount.Text);
            String txtC = txtCode.Text.ToString();



            //int index = fmScholarshipDetails.gvScholarshipDetails.RowCount - 1;

            //sd[index].ScholarshipCode = txtC;
            //sd[index].FeeID = feeID.FeeID;
            //sd[index].Discount = dis;

            //ScholarshipDiscount scholarshipDiscount = new ScholarshipDiscount()
            //{
            //    ScholarshipCode = txtCode.Text.ToString(),
            //    FeeID = feeID.FeeID,
            //    Discount = dis,
            //};
            //if (Op.Equals("edit"))
            //    ret = scholarshipService.UpdateScholarshipDiscount(ref scholarshipDiscount, ref message);
            //else
                //ret = scholarshipService.AddScholarshipDiscount(ref scholarshipDiscount, ScholarshipCodeString, ref message);

                //sd[0].ScholarshipCode = txtCode.Text.ToString();
                //sd[1].FeeID = feeID.FeeID;
                //sd[2].Discount = dis;
            


            //if (ret)
            //    MessageBox.Show("Saved Successfully");
            //else
            //    MessageBox.Show("Error Saving");

            Close();
        }


        private void btnCancelScholarshipDiscount_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
