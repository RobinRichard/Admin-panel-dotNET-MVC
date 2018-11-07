//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusicSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusicSheet()
        {
            this.PerformanceLists = new HashSet<PerformanceList>();
        }
    
        public int MusicSheetID { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public int MusicID { get; set; }
        public int InstrumentID { get; set; }
        public int CourseLevelID { get; set; }
        public string Name { get; set; }
    
        public virtual CourseLevel CourseLevel { get; set; }
        public virtual Instrument Instrument { get; set; }
        public virtual Music Music { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceList> PerformanceLists { get; set; }
    }
}
