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
    
    public partial class Performance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Performance()
        {
            this.PerformanceLists = new HashSet<PerformanceList>();
        }
    
        public int PerformanceID { get; set; }
        public System.DateTime PerformanceDate { get; set; }
        public string Loaction { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerformanceList> PerformanceLists { get; set; }
    }
}