﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSARServiceModels
{
    public class StudentTrait
    {
        StudentEnrollment MyStudent = new StudentEnrollment();
         
        public string StudentEnrTraitCode { get; set; }
         
        public string StudentSY { get; set; }
         
        public int TraitsID { get; set; }
         
        public string Description { get; set; }
         
        public Nullable<double> FirstPeriodicRating { get; set; }
         
        public Nullable<double> SecondPeriodicRating { get; set; }
         
        public Nullable<double> ThirdPeriodicRating { get; set; }
         
        public Nullable<double> FourthPeriodicRating { get; set; }
         
        public Nullable<bool> LockFirst { get; set; }
         
        public Nullable<bool> LockSecond { get; set; }
         
        public Nullable<bool> LockThird { get; set; }
         
        public Nullable<bool> LockFourth { get; set; }
         
        public Nullable<System.DateTime> FirstEntered { get; set; }
         
        public Nullable<System.DateTime> SecondEntered { get; set; }
         
        public Nullable<System.DateTime> ThirdEntered { get; set; }
         
        public Nullable<System.DateTime> FourthEntered { get; set; }
         
        public Nullable<System.DateTime> FourthLocked { get; set; }
         
        public Nullable<System.DateTime> ThirdLocked { get; set; }
         
        public Nullable<System.DateTime> SecondLocked { get; set; }
         
        public Nullable<System.DateTime> FirstLocked { get; set; }
         
        public StudentEnrollment StudentEnr
        {
            get { return MyStudent; }
            set { MyStudent = value; }
        }
         
        public Nullable<double> FinalRating { get; set; }
         
        public string Proficiency { get; set; }
         
        public string StudentId { get; set; }
         
        public string StudentName { get; set; }
         
        public string GradeLevel { get; set; }
         
        public string Section { get; set; }
         
        public int GradeSectionCode { get; set; }
         
        public string TeacherId { get; set; }
         
        public string TeacherName { get; set; }

    }
}
