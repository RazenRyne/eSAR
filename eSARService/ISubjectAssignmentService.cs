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
    public interface ISubjectAssignmentService
    {
        [OperationContract]
        List<GradeLevel> GetAllGradeLevels();
        [OperationContract]
        List<GradeSection> GetAllSections();
        [OperationContract]
        List<GradeSection> GetAllSectionsOfGradeLevel(string gradeLevel);
        [OperationContract]
        List<Subject> GetAllSubjects();
        [OperationContract]
        List<SubjectAssignment> GetAllSchedulesbySection(int iGradeSection,string sy);
        [OperationContract]
        List<Subject> GetAllSubjectsOfGradeLevel(string gradeLevel);
        [OperationContract]
        List<Timeslot> GetTimeslots();
        [OperationContract]
        List<Room> GetAllRooms();
        [OperationContract]
        List<Teacher> GetAllTeachers();
        [OperationContract]
        List<Room> GetAvailableRooms(string timeslotcode);
        [OperationContract]
        List<Teacher> GetAvailableTeachers(string timeslotcode);
        [OperationContract]
        List<SubjectAssignment> GetAllSchedules();  
        [OperationContract]
        List<SubjectAssignment> GetTeacherSchedule(string teacherId, string sy);
        [OperationContract]
        List<SubjectAssignment> GetRoomSchedule(int roomCode);
        [OperationContract]
        List<StudentSchedule> GetStudentSchedule(int gradeSectionCode,string sy);

        [OperationContract]
        List<SubjectAssignment> GetStudentExSchedule(int gradeSectionCOde, string sy);

        [OperationContract]
        Boolean CreateSchedule(List<SubjectAssignment> schedule);
        [OperationContract]
        Boolean UpdateSchedule(List<SubjectAssignment> schedule);

        [OperationContract]
        string GetCurrentSY();


        [OperationContract]
        Boolean CreateSchedules(SubjectAssignment subjectAssignment, string message);

        [OperationContract]
        Boolean DeleteSchedule(int schedId, ref string message);
        [OperationContract]
        List<SubjectAssignment> GetRightSchedule(int Rank, string GradeLevel);
        [OperationContract]
        SubjectAssignment GetScheduleInfo(int SubjecAssignmentsId);
        [OperationContract]
        List<SchoolYear> GetAllSY();
    }

    [DataContract]
    public class SubjectAssignment
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
        public int RoomId{ get; set; }
        [DataMember]
        public string TeacherId { get; set; }
        [DataMember]
        public int GradeSectionCode { get; set; }
        [DataMember]
        public int Class { get; set; }
        [DataMember]
        public bool Deactivated { get; set; }
        [DataMember]
        public int SubjectAssignmentsID { get; set; }
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
