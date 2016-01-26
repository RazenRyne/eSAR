using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IPaymentDetailsService
    {
        [OperationContract]
        Boolean CreatePaymentDetail(ref PaymentDetail pd, ref string message);
        [OperationContract]
        List<PaymentDetail> GetAllPaymentDetails();
    }

    [DataContract]
    public class PaymentDetail
    {
        [DataMember]
        public int DetailNumber { get; set; }
        [DataMember]
        public int ORNo { get; set; }
        [DataMember]
        public int FeeID { get; set; }
        [DataMember]
        public float Amout { get; set; }
    }
}
