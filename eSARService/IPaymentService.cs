using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IPaymentService
    {
        [OperationContract]
        Boolean CreatePayment(ref Payment payment, ref string message);
        [OperationContract]
        List<Payment> GetAllPayments();
        [OperationContract]
        List<PaymentDetail> GetAllPaymentDetails(int ORNo);
        [OperationContract]
        Payment GetPayment(int ORNo, ref string message);
        [OperationContract]
        List<Payment> GetAllStudentsPayments(string studentID);
        [OperationContract]
        String GetStudentName(string studentid);
    }

    [DataContract]
    public class Payment
    {
        //List<PaymentDetail> paymentList = new List<PaymentDetail>();
        [DataMember]
        public int ORNo { get; set; }
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public string SettlementFor { get; set; }
        [DataMember]
        public string ReceivedFrom { get; set; }
        [DataMember]
        public string TIN { get; set; }
        [DataMember]
        public string PaidAt { get; set; }
        [DataMember]
        public string BusinessStyle { get; set; }
        [DataMember]
        public int PaidTo { get; set; }
        [DataMember]
        public string PaidToName { get; set; }
        [DataMember]
        public Boolean Cancelled { get; set; }
        [DataMember]
        public float Amount { get; set; }
        [DataMember]
        public string Adres { get; set; }
        //[DataMember]
        //public List<PaymentDetail> PaymentDetails
        //{
        //    get { return this.paymentList; }
        //    set { this.paymentList = value; }
        //}
    }
}
