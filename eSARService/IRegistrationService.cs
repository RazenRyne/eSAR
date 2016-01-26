using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace eSARService
{
    [ServiceContract(Namespace = "DcfiWindowsService")]
    public interface IRegistrationService
    {
        [OperationContract]
        List<GradeLevel> GetAllGradeLevel();
        [OperationContract]
        List<SchoolYear> GetAllSY();
        [OperationContract]
        SchoolYear GetCurrentSY();
        [OperationContract]
        Student StudentInfoWithRank(string IDnum, string gradeLevel, string gender);
        [OperationContract]
        Boolean EnrolStudent(StudentEnrollment studentEnr);
        [OperationContract]
        Boolean EnrolIrregStudent(StudentEnrollment studentEnr);
        [OperationContract]
        List<string> GetEnrolledStudents(string sy);
        [OperationContract]
        List<StudentEnrollment> GetCurrentStudents(string sy);
        [OperationContract]
        StudentEnrollment GetStudentEnrolled(string IDNum, string SY);
        [OperationContract]
        Boolean CreateStudentAssessment(StudentAssessment studAss);
        [OperationContract]
        List<StudentAssessment> AssessMe(StudentEnrollment student);
        [OperationContract]
        List<StudentAssessment> GetStudentAssessment(string IDNum, string SY);
        [OperationContract]
        List<Fee> GetStudentFees(StudentEnrollment student);
        [OperationContract]
        List<ScholarshipDiscount> GetScholarshipDiscounts();
        [OperationContract]
        List<StudentSubject> GetFailedSubjects(string IDSy);
        [OperationContract]
        List<StudentSchedule> GetSubjectSchedules(string sy);
        [OperationContract]
        Boolean ControlSubjects(string StudentId, string sy, List<StudentSubject> subs);
        [OperationContract]
        Boolean DeleteLoadedSubjects(string StudentId, string sy, List<StudentSubject> subs);
        //[OperationContract]
        //void ControlStudent(StudentEnrollment student);
        [OperationContract]
        List<StudentSubject> GetStudentSubjects(string studentIdSy);
        [OperationContract]
        Student GetStudent(string StudentId, ref string message);
        [OperationContract]
        List<SubjectAssignment> GetStudentSchedule(int rank, string gradelevel);
        [OperationContract]
        List<StudentSchedule> GetStudentExistingSchedule(List<StudentSubject> StudentSubjectList,string sy);
        [OperationContract]
        bool UpdateStudent(ref Student student, ref string message);
        [OperationContract]
        List<StudentSchedule> GetSubjectsOfSection(int GradeSectionCode,string sy);
        [OperationContract]
        List<GradeSection> GetAllGradeSection(string gradeLevel);
    }


    [DataContract]
    public class StudentEnrollment {

        Student stu = new Student();
        [DataMember]
        public string StudentSY { get; set; }
        [DataMember]
        public string StudentId { get; set; }
        [DataMember]
        public string SY { get; set; }
        [DataMember]
        public string GradeLevel { get; set; }
        [DataMember]
        public int Rank { get; set; }
        [DataMember]
        public Nullable<int> GradeSectionCode { get; set; }
        [DataMember]
        public Nullable<bool> Dismissed { get; set; }
        [DataMember]
        public int StudentEnrollmentsID { get; set; }
        [DataMember]
        public int DiscountId { get; set; }
        [DataMember]
        public string Stat { get; set; }
        [DataMember]
        public string StudentName { get; set; }
        [DataMember]
        public Student student {
            get { return stu; }
            set { stu = value; }
        }

    }

    [DataContract]
    public class StudentSubject
    {
        StudentEnrollment MyStudent = new StudentEnrollment();
        [DataMember]
        public string StudentEnrSubCode { get; set; }
        [DataMember]
        public string StudentSY { get; set; }
        [DataMember]
        public string SubjectCode { get; set; }
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
        public string Remarks { get; set; }
        [DataMember]
        public int StudentSubjectsID { get; set; }

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
        public StudentEnrollment StudentEnr {
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
        public string SubjectAssignments { get; set; }
    }

    
    [DataContract]
    public class StudentAssessment
    {
        [DataMember]
        public int StudentAssessmentId { get; set; }
        [DataMember]
        public string StudentSY { get; set; }
        [DataMember]
        public int FeeID { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public int ScholarshipDiscountId { get; set; }
        [DataMember]
        public float Discount { get; set; }
    }

    [DataContract]
    public class StudentSchedule {
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
}