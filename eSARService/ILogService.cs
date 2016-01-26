using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface ILogService
    {

        [OperationContract]
        Boolean AddLogs(Log log);
       
        [OperationContract]
        List<Log> GetAllLogs();

        [OperationContract]
        List<Log> GetAllLogsByDate(DateTime from, DateTime to);
        
    }

    [DataContract]
    public class Log
    {
        [DataMember]
        public int LogId { get; set; }
        [DataMember]
        public string CLUD { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string TableName { get; set; }
        [DataMember]
        public System.DateTime LogDate { get; set; }
        [DataMember]
        public string PassedData { get; set; }
        [DataMember]
        public string UserName { get; set; }
    }


}