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
    public interface IGradingService
    {
        [OperationContract]
        List<StudentSubject> GetClassList(string SubjectAssignments);
        [OperationContract]
        Teacher GetTeacher(string lastname, string middlename, string firstname);
        [OperationContract]
        List<TeacherLoad> GetTeacherLoad(string TeacherId, string sy);
        [OperationContract]
        List<TeacherLoad> GetAllTeachersLoad(string sy);
        [OperationContract]
        void LockGrades(int Grading, List<StudentSubject> grades);
        [OperationContract]
        List<StudentSubject> GetClassGrades(string SubjectAssignments);
        [OperationContract]
        bool SaveClassGrades(List<StudentSubject> grades);
        [OperationContract]
        List<StudentSubject> GetStudentGrades(string StudentId, string sy);
        [OperationContract]
        List<StudentSubject> GetStudentEvaluation(string StudentId);
        [OperationContract]
        List<StudentTrait> GetAdvisees(int GradesectionCode);
        [OperationContract]
        List<StudentTrait> GetStudentTrait(string StudentId, string sy);
        [OperationContract]
        bool SaveTraitsGrade(List<StudentTrait> grades);
        [OperationContract]
        void LockTraitsGrade(int Grading, List<StudentTrait> grades);
        [OperationContract]
        Teacher GetTeacherDet(string teacherId, ref string message);
    }

    [DataContract]
    public class TeacherLoad
    {
        [DataMember]
        public string SY { get; set; }
        [DataMember]
        public string SubjectCode { get; set; }
        [DataMember]
        public string SubjectDescription { get; set; }
        [DataMember]
        public string TimeSlotCode { get; set; }
        [DataMember]
        public int RoomId { get; set; }
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int GradeSectionCode { get; set; }
        [DataMember]
        public int Class { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public string SubjectAssignments { get; set; }
        [DataMember]
        public GradeSection GradeSection { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public Room Room { get; set; }
        [DataMember]
        public string RoomCode { get; set; }
        [DataMember]
        public Subject Subject { get; set; }
        [DataMember]
        public Teacher Teacher { get; set; }
        [DataMember]
        public string TeacherName { get; set; }
        [DataMember]
        public Timeslot Timeslot { get; set; }
        [DataMember]
        public string Timestart { get; set; }
        [DataMember]
        public string TimeEnd { get; set; }
        [DataMember]
        public string Days { get; set; }
        [DataMember]
        public string TimeslotInfo { get; set; }
        [DataMember]
        public string SubjectInfo { get; set; }
        [DataMember]
        public bool Selected { get; set; }
    }
    [DataContract]
    public class StudentTrait {
        StudentEnrollment MyStudent = new StudentEnrollment();
        [DataMember]
        public string StudentEnrTraitCode { get; set; }
        [DataMember]
        public string StudentSY { get; set; }
        [DataMember]
        public int TraitsID { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public Nullable<double> FirstPeriodicRating { get; set; }
        [DataMember]
        public Nullable<double> SecondPeriodicRating { get; set; }
        [DataMember]
        public Nullable<double> ThirdPeriodicRating { get; set; }
        [DataMember]
        public Nullable<double> FourthPeriodicRating { get; set; }
        [DataMember]
        public Nullable<bool> LockFirst { get; set; }
        [DataMember]
        public Nullable<bool> LockSecond { get; set; }
        [DataMember]
        public Nullable<bool> LockThird { get; set; }
        [DataMember]
        public Nullable<bool> LockFourth { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FirstEntered { get; set; }
        [DataMember]
        public Nullable<System.DateTime> SecondEntered { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ThirdEntered { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FourthEntered { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FourthLocked { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ThirdLocked { get; set; }
        [DataMember]
        public Nullable<System.DateTime> SecondLocked { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FirstLocked { get; set; }
        [DataMember]
        public StudentEnrollment StudentEnr
        {
            get { return MyStudent; }
            set { MyStudent = value; }
        }
        [DataMember]
        public Nullable<double> FinalRating { get; set; }
        [DataMember]
        public string Proficiency { get; set; }
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
       public string GradeLevel { get; set; }
       [DataMember]
       public string Section { get; set; }
        [DataMember]
        public int GradeSectionCode { get; set; }
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public string TeacherName { get; set; }
        
    }
}
 