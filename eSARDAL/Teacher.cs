//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSARDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.GradeSections = new HashSet<GradeSection>();
            this.SubjectAssignments = new HashSet<SubjectAssignment>();
            this.TeacherChildrens = new HashSet<TeacherChildren>();
            this.TeacherEducationalBackgrounds = new HashSet<TeacherEducationalBackground>();
            this.TeacherEligibilities = new HashSet<TeacherEligibility>();
            this.TrainingSeminars = new HashSet<TrainingSeminar>();
            this.WorkExperiences = new HashSet<WorkExperience>();
        }
    
        public string TeacherId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public bool Deactivated { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string TIN { get; set; }
        public Nullable<System.DateTime> DateOfAppointment { get; set; }
        public string EmploymentStatus { get; set; }
        public string POBProvince { get; set; }
        public string POBMunicipality { get; set; }
        public string CivilStatus { get; set; }
        public Nullable<int> HeightCm { get; set; }
        public Nullable<double> WeightKg { get; set; }
        public string BloodType { get; set; }
        public string SSSNum { get; set; }
        public string PagIBIGNo { get; set; }
        public string PhilHealthNo { get; set; }
        public string RAStreetName { get; set; }
        public string RARegion { get; set; }
        public string RAProvince { get; set; }
        public string RAMunicipality { get; set; }
        public string ResTelephoneNo { get; set; }
        public string PAStreetName { get; set; }
        public string PARegion { get; set; }
        public string PAProvince { get; set; }
        public string PAMunicipality { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public string PreviousSchool { get; set; }
        public string DialectSpoken { get; set; }
        public string SpouseLastName { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddleName { get; set; }
        public string SpouseOccupation { get; set; }
        public string SpouseBusinessAdd { get; set; }
        public string SpouseEmployerName { get; set; }
        public string SpouseTelephoneNo { get; set; }
        public string PERAA { get; set; }
        public byte[] Image { get; set; }
        public Nullable<bool> Academic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeSection> GradeSections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubjectAssignment> SubjectAssignments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherChildren> TeacherChildrens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherEducationalBackground> TeacherEducationalBackgrounds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeacherEligibility> TeacherEligibilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrainingSeminar> TrainingSeminars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
