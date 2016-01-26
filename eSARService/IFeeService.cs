using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IFeeService
    {
        [OperationContract]
        Boolean UpdateFee(ref Fee fee, ref string message);
        [OperationContract]
        Boolean CreateFee(ref Fee fee, ref string message);
        [OperationContract]
        List<Fee> GetAllFees();
        [OperationContract]
        List<Fee> GetAllFeesForGradeLevel(string gradeLevel, string currSY);
        [OperationContract]
        List<GradeLevel> GetAllGradeLevels();
        [OperationContract]
        List<SchoolYear> GetLastFiveSY();
        [OperationContract]
        Fee GetFeeForAll(string currSY);
    }
    [DataContract]
    public class Fee
    {
        [DataMember]
        public int FeeID { get; set; }
        [DataMember]
        public int NumPay { get; set; }
        [DataMember]
        public float DiscountFullPay { get; set; }
        [DataMember]
        public string FeeDescription { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public Nullable<double> Amount { get; set; }
        [DataMember]
        public string SYImplemented { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string GradeLev { get; set; }
    }
}
