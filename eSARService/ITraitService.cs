using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface ITraitService
    {
        [OperationContract]
        List<Trait> GetAllTraits(); // with no gradelevel
        [OperationContract]
        List<Trait> GetAllTraitsOfCategory(int cat);//with gradelevel
        [OperationContract]
        Boolean CreateTrait(ref Trait trait, ref string message);//with no gradelevel
        [OperationContract]
        Boolean UpdateTrait(ref Trait trait, ref string message);
        
     
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "eSARService.ContractType".
    [DataContract]
    public class Trait
    {
       [DataMember]
        public int TraitsID { get; set; }
        [DataMember]
        public bool CurrTrait { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Category { get; set; }
        [DataMember]
        public string Cat { get; set; }
    }
}
