using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IScholarshipService
    {
        [OperationContract]
        List<ScholarshipDiscount> GetAllScholarships();
        [OperationContract]
        Boolean CreateScholarship(ref ScholarshipDiscount scholarship, ref string message);
        [OperationContract]
        Boolean AddScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, int scholarshipCode, ref string message);
        [OperationContract]
        Boolean UpdateScholarship(ref ScholarshipDiscount scholarship, ref string message);
        [OperationContract]
        List<Student> GetAllScholarsOfScholarship(int scholarshipCode);
        [OperationContract]
        List<Student> GetAllScholars();
        [OperationContract]
        List<ScholarshipDiscount> GetAllScholarshipDiscount(int scholarshipCode);
        [OperationContract]
        Boolean DeleteScholarshipDiscount(int scholarshipDiscountId);
        [OperationContract]
        Boolean UpdateScholarshipDiscount(ref ScholarshipDiscount scholarshipDiscount, ref string message);
    
    }

    [DataContract]
    public class ScholarshipDiscount
    {
        [DataMember]
        public int ScholarshipDiscountId { get; set; }
        
        [DataMember]
        public Nullable<double> Discount { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
     
        [DataMember]
        public string Scholarship { get; set; }
        [DataMember]
        public string Description{ get; set; }
    }

   
}
