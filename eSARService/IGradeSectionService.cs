using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IGradeSectionService
    {
        [OperationContract]
        List<GradeSection> GetAllGradeSections();
        [OperationContract]
        List<GradeSection> GetAllSectionsForGrade(string gradeLevel);
        [OperationContract]
        Boolean CreateGradeSection(ref GradeSection gs, ref string message);
        [OperationContract]
        Boolean UpdateGradeSection(ref GradeSection gs, ref string message);
        [OperationContract]
        List<Room> GetAllRooms();
        [OperationContract]
        List<Teacher> GetAllTeachers();
        [OperationContract]
        List<SchoolYear> GetAllSchoolYears();
        [OperationContract]
        List<GradeLevel> GetAllGradeLevels();
        [OperationContract]
        Teacher GetTeacher(string lastname, string middlename, string firstname);
        [OperationContract]
        Teacher GetTeacherDetail(string teacherID, ref string message);

    }
    [DataContract]
    public class GradeSection
    {
        List<SubjectAssignment> subass = new List<SubjectAssignment>();
        //List<StudentEnrollment> studenr = new List<StudentEnrollment>();
        [DataMember]
        public int GradeSectionCode { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public int HomeRoomNumber { get; set; }
        [DataMember]
        public string SY { get; set; }
        [DataMember]
        public string HomeRoomTeacherId { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public Teacher HomeRoomTeacher { get; set; }
        [DataMember]
        public Room HomeRoom { get; set; }
        [DataMember]
        public SchoolYear SchoolYr { get; set; }
        [DataMember]
        public String TeacherName { get; set; }
        [DataMember]
        public Nullable<int> Class { get; set; }

        [DataMember]
        public List<SubjectAssignment> SubjectAssignments { get { return this.subass; } set { this.subass = value; } }
        //[DataMember]
        //public List<StudentEnrollment> StudentEnrollments { get{return this.studenr;} set{this.studenr=value;} }
    }
}
