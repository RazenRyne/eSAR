using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using eSARServices;
using eSARServiceInterface;
using eSARServiceModels;
using System.Linq;
using eSAR.Utility_Classes;
using Newtonsoft.Json;
using Telerik.WinControls.UI;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace eSAR.Admission_and_Registration
{
    public partial class AssessStudent : Telerik.WinControls.UI.RadForm
    {
        public string StudentId { get; set; }
        public StudentEnrollment StudentAssessed = new StudentEnrollment();
        public SchoolYear currentSY = new SchoolYear();

        // Public Variables
        public double subTotalValue = 0;
        public double amountTuition = 0;
        public double enrollment = 0;
        public double percValue = 0;
        public double finalPercentDisc = 0;
        public double fullPaymentDiscount = 0;
        public double discountByAmountPar = 0;

        // public IEnumerable<StudentAssesment> assess= new List<StudentAssesment>();

        public AssessStudent()
        {
            InitializeComponent();
        }

        private void radTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssessStudent_Load(object sender, EventArgs e)
        {
            IRegistrationService registrationService = new RegistrationService();
            List<Fee> fees = new List<Fee>();
            IScholarshipService scholarshipService = new ScholarshipService();
            List<ScholarshipDiscount> scholarships = new List<ScholarshipDiscount>();

            currentSY = registrationService.GetCurrentSY();

            StudentAssessed = registrationService.GetStudentEnrolled(StudentId, currentSY.SY);
            txtGradeLevel.Text = StudentAssessed.GradeLevel;
            txtIDnum.Text = StudentAssessed.StudentId;
            txtName.Text = StudentAssessed.StudentName;
            txtSY.Text = currentSY.SY;

            
            fees = new List<Fee>(registrationService.GetStudentFees(StudentAssessed));
            gvAssessment.DataSource = fees;
            fees.ToArray();

            scholarships = new List<ScholarshipDiscount>(registrationService.GetScholarshipDiscounts());

            int scholarshipDiscountId = StudentAssessed.DiscountId;

            ScholarshipDiscount sd = new ScholarshipDiscount();

            sd = scholarships.Find(v => v.ScholarshipDiscountId == scholarshipDiscountId);

            amountTuition = (double)fees[0].Amount;
            enrollment = (double)fees[1].Amount;

            // Read Only TextBox
            tuitionFee.ReadOnly = true;
            discountPercent.ReadOnly = true;
            totalTuitionFee.ReadOnly = true;
            enrollmentFee.ReadOnly = true;
            enrTotalTuitionFee.ReadOnly = true;
            subTotal.ReadOnly = true;
            discountbyAmountSubTotal.ReadOnly = true;
            Total.ReadOnly = true;


            // Total Tuition Fee
            tuitionFee.Text = amountTuition.ToString("0.###");

            // Percent Discount
            double perc = 0;
            double percRound = 0;
            double percInitial = 0;
            
            perc = (double)sd.Discount;
            if (sd.Discount == null)
            {
                discountPercent.Enabled = false;
            }
            else
            {
                discountPercent.Text = perc.ToString("0.##");
                percRound = perc / 100;
                if (percRound == 1)
                {
                    percValue = amountTuition;
                    fullPaymentDisc.ReadOnly = true;
                } else { 
                    percInitial = amountTuition * percRound;
                    percValue = amountTuition - percInitial;
                }
            }

               /* Operations */
            // Operation for Percent Discount if not null
            
            if (fullPaymentDisc != null)
            {
                finalPercentDisc = amountTuition - percValue - fullPaymentDiscount;
            }
            else
            {
                finalPercentDisc = amountTuition - percValue;
            }

            // Total Tuition Fee
            totalTuitionFee.Text = finalPercentDisc.ToString("0.##");

            // Enrollment Fee
            enrollmentFee.Text = enrollment.ToString();

            // Total Tuition Fee
            enrTotalTuitionFee.Text = finalPercentDisc.ToString("0.##");

            // Sub Total
            
            subTotalValue = enrollment + finalPercentDisc;
            subTotal.Text = subTotalValue.ToString("0.##");


            // Sub Total 
            discountbyAmountSubTotal.Text = subTotalValue.ToString("0.##");

            // Discount by Amount
            double discByAmout = 0;
            //discByAmout = discountByAmount


            // Para ma assess og ma save sa db
            //var assessments = registrationService.AssessMe(StudentAssessed);

            //gvAssessment.DataSource = assessments;



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(fullPaymentDisc.Text) && string.IsNullOrWhiteSpace(discountByAmount.Text))
            {
                Total.Text = subTotalValue.ToString("0.##");
            }
            else if (!string.IsNullOrWhiteSpace(fullPaymentDisc.Text) && !string.IsNullOrWhiteSpace(discountByAmount.Text))
            {
                string fullPaymentDiscS = fullPaymentDisc.ToString();
                string discountByAmountS = discountByAmount.ToString();


                // Full Payment Discount Part

                if (double.TryParse(fullPaymentDisc.Text, out fullPaymentDiscount)) ;

                double partialValue = 0;
                partialValue = amountTuition - percValue - fullPaymentDiscount;

                totalTuitionFee.Text = partialValue.ToString("0.##");
                enrTotalTuitionFee.Text = partialValue.ToString("0.##");


                double subTotalPar = 0;

                subTotalPar = enrollment + partialValue;

                subTotal.Text = subTotalPar.ToString("0.##");

                discountbyAmountSubTotal.Text = subTotalPar.ToString("0.##");

                // Discount by Amount Part
                if (double.TryParse(discountByAmount.Text, out discountByAmountPar)) ;

               
                double partialValueDiscbyAmo = 0;
                partialValueDiscbyAmo = subTotalPar - discountByAmountPar;
                Total.Text = partialValueDiscbyAmo.ToString("0.##");





            }
            else if (!string.IsNullOrWhiteSpace(fullPaymentDisc.Text))
            {
                if (double.TryParse(fullPaymentDisc.Text, out fullPaymentDiscount)) ;

                double partialValue = 0;
                partialValue = amountTuition - percValue - fullPaymentDiscount;

                totalTuitionFee.Text = partialValue.ToString("0.##");
                enrTotalTuitionFee.Text = partialValue.ToString("0.##");


                double subTotalPar = 0;

                subTotalPar = enrollment + partialValue;

                subTotal.Text = subTotalPar.ToString("0.##");

                discountbyAmountSubTotal.Text = subTotalPar.ToString("0.##");

                Total.Text = subTotalPar.ToString("0.##");
            }
            else if (!string.IsNullOrWhiteSpace(discountByAmount.Text))
            {
                if (double.TryParse(discountByAmount.Text, out discountByAmountPar));

                if (subTotalValue < discountByAmountPar)
                {
                    MessageBox.Show(this, "Discount is greater than Sub Total");
                }
                else
                {
                    double partialValue = 0;
                    partialValue = subTotalValue - discountByAmountPar;
                    Total.Text = partialValue.ToString("0.##");

                }
                
            }
                
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            calculate.Visible = false;
            IRegistrationService registrationService = new RegistrationService();
            ILogService logService = new LogService();
            var assessments = registrationService.AssessMe(StudentAssessed);
            if (assessments.Count > 0)
            {
                string json = JsonConvert.SerializeObject(StudentAssessed);
                Log log = new Log
                {
                    CLUD = "C",
                    LogDate = DateTime.Now,
                    TableName = "StudentAssessment",
                    UserId = GlobalClass.user.UserId,
                    UserName = GlobalClass.user.UserName,
                    PassedData = json
                };
                logService.AddLogs(log);

                PrintPane();
                calculate.Visible = true;
            }
        }     
        
        private void PrintPane()
        {
            txtDate.Text = "Date: " + DateTime.Now.ToShortDateString();
            txtDate.Visible = true;
            radPanel2.Size = new Size(702, 586);
            this.Size = new Size(710, 657);


            RadPrintDocument document = new RadPrintDocument();
            document.AssociatedObject = new PanelPrinter(this.radPanel2);
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(document);
            dialog.ShowDialog();

            
            txtDate.Visible = false;
            radPanel2.Size = new Size(702, 361);
            this.Size = new Size(710, 431);
        }

    }

    public class PanelPrinter : IPrintable
    {
        private RadPanel panel;

        public PanelPrinter(RadPanel panel)
        {
            this.panel = panel;
        }

        public int BeginPrint(RadPrintDocument sender, PrintEventArgs args)
        {
            return 1;
        }

        public bool EndPrint(RadPrintDocument sender, PrintEventArgs args)
        {
            return false;
        }

        public Form GetSettingsDialog(RadPrintDocument document)
        {
            return null;
        }

        public bool PrintPage(int pageNumber, RadPrintDocument sender, PrintPageEventArgs args)
        {
            float scale = Math.Min((float)args.MarginBounds.Width / panel.Size.Width, (float)args.MarginBounds.Height / panel.Size.Height);

            Bitmap panelBmp = new Bitmap(this.panel.Width, this.panel.Height);
            this.panel.DrawToBitmap(panelBmp, this.panel.Bounds);

            Matrix saveMatrix = args.Graphics.Transform;
            args.Graphics.ScaleTransform(scale, scale);
            args.Graphics.DrawImage(panelBmp, args.MarginBounds.Location);
            args.Graphics.Transform = saveMatrix;

            return false;
        }
    }

}
