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
    
    public partial class SubjectAssignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectAssignment()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int SubjectAssignmentsID { get; set; }
        public string SY { get; set; }
        public string SubjectCode { get; set; }
        public string TeacherId { get; set; }
        public Nullable<bool> Deactivated { get; set; }
        public Nullable<int> GradeSectionCode { get; set; }
        public Nullable<int> RoomId { get; set; }
        public string TimeSlotCode { get; set; }
    
        public virtual Room Room { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Timeslot Timeslot { get; set; }
    }
}
